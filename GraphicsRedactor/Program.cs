using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsRedactor
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle square = new Rectangle(0, 0, "|", 25, 6, ConsoleColor.Red);
            square.Draw();
        }
    }
}
