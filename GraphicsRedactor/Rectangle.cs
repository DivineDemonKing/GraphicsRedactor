using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsRedactor
{
    class Rectangle : Content
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Rectangle(int x, int y, string symbol, int width, int height, ConsoleColor color)
        {
            X = x;
            Y = y;
            Symbol = symbol;
            Width = width;
            Height = height;
            Color = color;
        }
        public void Draw()
        {
            Console.ForegroundColor = Color;
            double temp = ((Height + 1.4) / 2.4);
            int tempLength = (int)Math.Round(temp);

            //Циклы отвечающие за рисование горизонтальных линий
            for (int i = 0; i < Width; i++)
            {
                Console.SetCursorPosition(X + i, Y);
                Console.WriteLine(Symbol);
            }

            for (int i = 0; i < Width; i++)
            {
                Console.SetCursorPosition(X + i, Y + Height - 1);
                Console.WriteLine(Symbol);
            }

            //Циклы отвечающие за рисование вертикальных линий    

            for (int i = 0; i < Height; i++)
            {
                Console.SetCursorPosition(X, Y + i);
                Console.WriteLine(Symbol);
            }

            for (int i = 0; i < Height; i++)
            {
                Console.SetCursorPosition(X + Width - 1, Y + i);
                Console.WriteLine(Symbol);
            }
            Console.ResetColor();
        }       
    }
}
