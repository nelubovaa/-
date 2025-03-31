using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace даша
{
    internal class Rectangle
    {
        private double A { get; set; }
        private double B { get; set; }
        public void ShowDetails()
        {
            Console.WriteLine($"Высота: {A}, Ширина: {B}");
        }

        public double P()
        {
            return 2 * A + 2 * B;
        }
    }
}
