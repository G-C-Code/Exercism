using System;

public class Queen
{
    public Queen(int row, int column)
    {
        Row = row;
        Column = column;
    }

    public int Row { get; }
    public int Column { get; }
}

public static class QueenAttack
{
    public static bool CanAttack(Queen white, Queen black)
    {
        if (white.Column < 0 || white.Column > 7 || white.Row < 0 || white.Row > 7 || black.Column < 0 || black.Column > 7 || black.Row < 0 || black.Row > 7)
        {
            throw new ArgumentOutOfRangeException();
        }
        else
        {
            int rowDif = white.Row - black.Row;
            int colDif = white.Column - black.Column;

            if (white.Column == black.Column && white.Row == black.Row)
                throw new ArgumentException();
            else if (white.Column == black.Column || white.Row == black.Row || Math.Abs(white.Column - black.Column) == Math.Abs(white.Row - black.Row))
                return true;
            else
                return false;
        }
    }

    public static Queen Create(int row, int column)
    {
        if (column < 0 || column > 7 || row < 0 || row > 7)
        {
            throw new ArgumentOutOfRangeException();
        }
        else
        {
            return new(row, column);
        }
    } 
}