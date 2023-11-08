using System;
using System.Collections.Generic;

public class BowlingGame
{
    public List<Frame> Frames = new();
    public int FrameCount = 1;
    public bool FirstThrow = true;
    public bool FillBall;
    public int FirstRoll { get; set; }
    public int SecondRoll { get; set; }
    public int ThirdRoll { get; set; }

    public void Roll(int pins) 
    {
        if (pins > 10 || pins < 0 || FrameCount > 10)
            throw new ArgumentException();


        if (FrameCount < 10) //First frames
        {
            if (FirstThrow)
            {
                FirstRoll = pins;
                
                if (pins == 10) //Strike
                {
                    Frame frame = new(FirstRoll, 0);
                    Frames.Add(frame);

                    FirstRoll = 0;
                    SecondRoll = 0;
                    FrameCount++;
                }
                else
                {
                    FirstThrow = false;
                }
            }
            else
            {
                SecondRoll = pins;

                if (FirstRoll + SecondRoll > 10)
                    throw new ArgumentException();

                Frame frame = new(FirstRoll, SecondRoll);
                Frames.Add(frame);

                FirstThrow = true;
                FirstRoll = 0;
                SecondRoll = 0;
                FrameCount++;
            }
        }
        else
        {
            if (FirstThrow)
            {
                FirstRoll = pins;
                FirstThrow = false;
            }
            else
            {
                if(!FillBall)
                {
                    SecondRoll = pins;

                    if (FirstRoll != 10 && FirstRoll + SecondRoll > 10)
                        throw new ArgumentException();

                    if (FirstRoll == 10 || FirstRoll + SecondRoll == 10)
                        FillBall = true;

                    if (FirstRoll + SecondRoll < 10)
                        FrameCount++;

                    Frame frame = new(FirstRoll, SecondRoll);
                    Frames.Add(frame);

                    FirstRoll = 0;
                    SecondRoll = 0;
                }
                else
                {
                    ThirdRoll = pins;
                    FrameCount++;
                }
            }
        }

    }

    public int? Score()
    {
        if (Frames.Count != 10)
            throw new ArgumentException();

        int score = 0;

        for (int i = 0; i < Frames.Count; i++ )
        {
            if (i < 8)
            {
                if (Frames[i].FirstRoll == 10 && Frames[i+1].FirstRoll == 10)
                {
                    Frames[i].FirstRoll += Frames[i+1].FirstRoll + Frames[i+2].FirstRoll;
                }
                else if (Frames[i].FirstRoll == 10)
                {
                    Frames[i].FirstRoll += Frames[i+1].FirstRoll + Frames[i+1].SecondRoll;
                }
                else if (Frames[i].FirstRoll + Frames[i].SecondRoll == 10)
                {
                    Frames[i].FirstRoll += Frames[i+1].FirstRoll;
                }
            }
            else if (i == 8)
            {
                if (Frames[i].FirstRoll == 10)
                {
                    Frames[i].FirstRoll += Frames[i+1].FirstRoll + Frames[i+1].SecondRoll;
                }
                else if (Frames[i].FirstRoll + Frames[i].SecondRoll == 10)
                {
                    Frames[i].SecondRoll += Frames[i+1].FirstRoll;
                }
            }
        }

        if (FillBall)
            score += ThirdRoll;

        foreach (Frame f in Frames)
        {
            score += f.FirstRoll + f.SecondRoll;
        }

        return score;
    }
}

public class Frame
{
    public int FirstRoll { get; set; }
    public int SecondRoll { get; set; }

    public Frame (int firstRoll, int secondRoll)
    {
        FirstRoll = firstRoll;
        SecondRoll = secondRoll;
    }
}
