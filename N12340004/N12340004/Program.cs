using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N12340004
{
    public class Rectangle
    {
        public int width;
        public int height;

        public Rectangle() { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle1 = new Rectangle();
            Rectangle rectangle2 = new Rectangle();
            rectangle1.width = 10;
            rectangle1.height = 5;
            rectangle2.width = 15;
            rectangle2.height = 20;
            Console.WriteLine($"長方形1 面積:{rectangle1.width * rectangle1.height}");
            Console.WriteLine($"長方形2 面積:{rectangle2.width * rectangle2.height}");
            Console.Read();
        }
    }

}
