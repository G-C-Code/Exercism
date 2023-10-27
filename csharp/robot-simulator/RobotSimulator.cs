using System;

public enum Direction
{
    North,
    East,
    South,
    West
}

public class RobotSimulator
{
    private Direction _direction;
    private int _x;
    private int _y;

    public RobotSimulator(Direction direction, int x, int y)
    {
        _direction = direction;
        _x = x;
        _y = y;
    }

    public Direction Direction
    {
        get { return _direction; }
    }

    public int X
    {
        get { return _x; }
    }

    public int Y
    {
        get { return _y; }
    }

    public void Move(string instructions)
    {
        foreach (char c in instructions)
        {
            switch (c)
            {
                case 'R':
                    _direction = (int)_direction < 3 ? _direction + 1 : 0;
                    break;
                case 'L':
                    _direction = (int)_direction != 0 ? _direction - 1 : _direction + 3;
                    break;
                case 'A':
                    if (_direction == Direction.North)
                        _y++;
                    else if (_direction == Direction.East)
                        _x++;
                    else if (_direction == Direction.South)
                        _y--;
                    else
                        _x--;
                    break;
                default:
                    
                    break;
            }
        }
    }
}