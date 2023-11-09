using System;
using System.Collections.Generic;

public class BowlingGame
{
    public List<Frame> Frames = new();
    public int FrameCount = 1;
    public bool SecondThrow;
    public bool FillBall;
    public int FirstRoll = 0;
    public int SecondRoll = 0;
    public int ThirdRoll = 0;

    public void Roll(int pins) 
    {
        if (pins > 10 || pins < 0 || FrameCount > 10)
            throw new ArgumentException();

        if (FrameCount < 10) //First frames
        {
            if (!SecondThrow)
            {
                FirstRoll = pins;
                
                if (pins == 10) //Strike
                {
                    FrameCount++;
                    Frame frame = new(FirstRoll, 0);
                    Frames.Add(frame);
                    FirstRoll = 0;
                    SecondRoll = 0;
                }
                else
                {
                    SecondThrow = true;
                }
            }
            else
            {
                SecondRoll = pins;

                if (FirstRoll + SecondRoll > 10)
                    throw new ArgumentException();

                FrameCount++;
                Frame frame = new(FirstRoll, SecondRoll);
                Frames.Add(frame);
                SecondThrow = false;
                FirstRoll = 0;
                SecondRoll = 0;
            }
        }
        else //Last frame
        {
            if (!SecondThrow)
            {
                FirstRoll = pins;
                SecondThrow = true;
            }
            else
            {
                if(!FillBall)
                {
                    SecondRoll = pins;

                    if (FirstRoll != 10 && FirstRoll + SecondRoll > 10)
                        throw new ArgumentException();

                    if (FirstRoll == 10 || FirstRoll != 10 && FirstRoll + SecondRoll == 10)
                    {
                        FillBall = true;
                    }
                    else if (FirstRoll + SecondRoll < 10)
                    {
                        FrameCount++;
                        Frame frame = new(FirstRoll, SecondRoll);
                        Frames.Add(frame);
                    }
                }
                else if (FillBall)
                {
                    ThirdRoll = pins;

                    if (FirstRoll == 10 && SecondRoll != 10 && SecondRoll + ThirdRoll > 10)
                        throw new ArgumentException();

                    FrameCount++;
                    Frame frame = new(FirstRoll, SecondRoll);
                    Frames.Add(frame);
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
                    Frames[i].FirstRoll += Frames[i+1].FirstRoll + Frames[i+2].FirstRoll;
                else if (Frames[i].FirstRoll == 10)
                    Frames[i].FirstRoll += Frames[i+1].FirstRoll + Frames[i+1].SecondRoll;
                else if (Frames[i].FirstRoll + Frames[i].SecondRoll == 10)
                    Frames[i].FirstRoll += Frames[i+1].FirstRoll;
            }
            else if (i == 8)
            {
                if (Frames[i].FirstRoll == 10)
                    Frames[i].FirstRoll += Frames[i+1].FirstRoll + Frames[i+1].SecondRoll;
                else if (Frames[i].FirstRoll + Frames[i].SecondRoll == 10)
                    Frames[i].SecondRoll += Frames[i+1].FirstRoll;
            }
        }

        score += ThirdRoll;

        foreach (Frame f in Frames)
            score += f.FirstRoll + f.SecondRoll;

        return score;
    }
}

public class Frame
{
    public int FirstRoll { get; set; }
    public int SecondRoll { get; set; }
    public Frame (int firstRoll, int secondRoll) => (FirstRoll, SecondRoll) = (firstRoll, secondRoll);
}
