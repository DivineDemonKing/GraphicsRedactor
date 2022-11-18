using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsRedactor
{
    class Square : Content
    {
        public int Length { get; set; }
        public Square (int x, int y, string symbol, int length, ConsoleColor color)
        {
            X = x;
            Y = y;
            Symbol = symbol;
            Length = length;
            Color = color;
        }

        public void Draw()
        {
            Console.ForegroundColor = Color;
            //Циклы отвечающие за рисование горизонтальных линий
            for (int i = 0; i < Length; i++)
            {
                Console.SetCursorPosition(X + i, Y);
                Console.WriteLine(Symbol);
            }

            for (int i = 0; i < Length; i++)
            {
                Console.SetCursorPosition(X + i, Length - 1 + Y);
                Console.WriteLine(Symbol);
            }

            //Циклы отвечающие за рисование вертикальных линий        

            for (int i = 0; i < Length; i++)
            {
                Console.SetCursorPosition(X, Y + i);
                Console.WriteLine(Symbol);
            }

            for (int i = 0; i < Length; i++)
            {
                Console.SetCursorPosition(X + Length - 1, Y + i);
                Console.WriteLine(Symbol);
            }
            Console.ResetColor();
        }
    }
}
