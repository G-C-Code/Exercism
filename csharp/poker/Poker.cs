using System;
using System.Linq;
using System.Collections.Generic;
//This is for giggles / code golfing, not to be taken (to) seriosly.
public static class Poker {
    private enum HandRank { HighCard, Pair, TwoPair, ThreeOfAKind, Straight, Flush, FullHouse, FourOfAKind, StraightFlush }
    private static (int[] cardValues, bool isFlush, string hand) AnalyzeHand(this string hand) => 
        (hand.Split(' ').Select(c => ("__234567891JQKA".IndexOf(c[0]), c.Last())).OrderByDescending(c => c.Item1).Select(c => c.Item1).ToArray(), 
         hand.Split(' ').Select(c => c.Last()).Distinct().Count() == 1, hand);
    private static (HandRank rank, int[] sortedValues, string hand) EvaluateHand(this (int[] cardValues, bool isFlush, string hand) parsedHand) {
        var groups = parsedHand.cardValues.GroupBy(v => v).OrderByDescending(g => g.Count()).ThenByDescending(g => g.Key).ToList();
        var values = groups.Select(g => g.Key).ToArray();
        var straight = values.OrderBy(v => v).SequenceEqual(Enumerable.Range(values.Min(), 5)) || values.OrderBy(v => v).SequenceEqual(new[] { 2, 3, 4, 5, 14 });
        var handRank = groups.Count == 5 ? (straight && parsedHand.isFlush ? HandRank.StraightFlush : straight ? HandRank.Straight : parsedHand.isFlush ? HandRank.Flush : HandRank.HighCard) : groups.Count == 4 ? HandRank.Pair : groups.Count == 3 ? (groups.Any(g => g.Count() == 3) ? HandRank.ThreeOfAKind : HandRank.TwoPair) : groups.Any(g => g.Count() == 4) ? HandRank.FourOfAKind : HandRank.FullHouse;
        return (handRank, handRank == HandRank.Straight && values.Contains(14) && values.Contains(2) ? values.Where(v => v != 14).Append(1).ToArray() : values, parsedHand.hand);
    }
    private static (string hand, int score) CalculateScore(this (HandRank rank, int[] sortedValues, string hand) classifiedHand) => (classifiedHand.hand, classifiedHand.sortedValues.Aggregate(0, (total, value) => total * 14 + value));
    public static IEnumerable<string> BestHands(IEnumerable<string> hands) => 
        hands.Select(AnalyzeHand).Select(EvaluateHand).GroupBy(hand => hand.rank).OrderByDescending(group => group.Key).First()
        .GroupBy(hand => hand.sortedValues.Aggregate(0, (total, value) => total * 14 + value)).OrderByDescending(group => group.Key).First()
        .Select(hand => hand.hand);
}