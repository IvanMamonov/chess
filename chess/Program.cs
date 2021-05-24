using System;

namespace Chess
{
    class Program
    {
        static void Main()
        {
            string figure = Console.ReadLine();
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int newX = int.Parse(Console.ReadLine());
            int newY = int.Parse(Console.ReadLine());
            Figure fig;
            switch (figure)
            {
                case "N":
                    fig = new Knight(x, y);
                    break;

                case "Q":
                    fig = new Queen(x, y);
                    break;

                case "B":
                    fig = new Bishop(x, y);
                    break;

                case "K":
                    fig = new King(x, y);
                    break;

                case "R":
                    fig = new Rook(x, y);
                    break;

                default:
                    return;
            }
            Console.WriteLine(fig.Move(newX, newY));
        }
    }
    class Figure
    {
        protected int x1;
        protected int y1;
        public Figure(int x1, int y1)
        {
            this.x1 = x1;
            this.y1 = y1;
        }
        public virtual bool Move(int x2, int y2)
        {
            return false;
        }
    }
    class King : Figure
    {
        public King(int x1, int y1) : base(x1, y1)
        { 
        }
        public override bool Move(int newX, int newY)
        {
            return (Math.Abs(x1 - newX) <= 1 && Math.Abs(y1 - newY) <= 1);
        }
    }
    class Queen : Figure
    {
        public Queen(int x1, int y1) : base(x1, y1)
        {
        }
        public override bool Move(int newX, int newY)
        {
            return (x1 == newX || y1 == newY || Math.Abs(x1 - newX) == Math.Abs(y1 - newY));
        }
    }
    class Rook : Figure
    {
        public Rook(int x1, int y1) : base(x1, y1)
        {
        }
        public override bool Move(int newX, int newY)
        {
            return (x1 == newX || y1 == newY);
        }
    }
    class Bishop : Figure
    {
        public Bishop(int x1, int y1) : base(x1, y1)
        {
        }
        public override bool Move(int newX, int newY)
        {
            return Math.Abs(x1 - newX) == Math.Abs(y1 - newY);
        }
    }
    class Knight : Figure
    {
        public Knight(int x1, int y1) : base(x1, y1)
        {
        }
        public override bool Move(int newX, int newY)
        {
            return ((Math.Abs(x1 - newX) == 2 && Math.Abs(y1 - newY) == 1) || (Math.Abs(x1 - newX) == 1 && Math.Abs(y1 - newY) == 2));
        }
    }
}
