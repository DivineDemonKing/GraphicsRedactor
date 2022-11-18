using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsRedactor
{
    class Triangle : Content
    {
        public int Length { get; set; }
        public Triangle(int x, int y, string symbol, int length, ConsoleColor color)
        {
            X = x;
            Y = y;
            Length = length;
            Symbol = symbol;
            Color = color;
        }
        public void Draw()
        {
            Console.ForegroundColor = Color;
            for (int i = 0; i < Length; i++)
            {
                Console.SetCursorPosition(X - i, Y + i);
                Console.WriteLine(Symbol);
            }

            for (int i = 0; i < Length; i++)
            {
                Console.SetCursorPosition(X + i, Y + i);
                Console.WriteLine(Symbol);
            }

            for (int i = 0; i < Length * 2 + 1; i++)
            {
                Console.SetCursorPosition(X - i + Length, Y + Length);
                Console.WriteLine(Symbol);
            }
            Console.ResetColor();
        }
    }
}
