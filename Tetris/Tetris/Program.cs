using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);


            FigureGenerator generator = new FigureGenerator(20, 0, '#');
            Figure s = generator.GetNewFigure();

            s.Draw();

            Thread.Sleep(500);
            s.Hide();
            s.Rotate();
            s.Draw();

            Thread.Sleep(500);
            s.Hide();
            s.Move(Direction.LEFT);
            s.Draw();

            Thread.Sleep(500);
            s.Hide();
            s.Move(Direction.DOWN);
            s.Draw();

            Thread.Sleep(500);
            s.Hide();
            s.Move(Direction.DOWN);
            s.Draw();

            Thread.Sleep(500);
            s.Hide();
            s.Move(Direction.RIGHT);
            s.Draw();

            Thread.Sleep(500);
            s.Hide();
            s.Move(Direction.RIGHT);
            s.Draw();

            Thread.Sleep(500);
            s.Hide();
            s.Rotate();
            s.Draw();

            Console.ReadLine();
        }
    }
}