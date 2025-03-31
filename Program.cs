using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace даша
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.A = 2;
            rect.B = 3;
            rect.ShowDetails();
            double p = rect.P();
            Console.WriteLine($"Периметр: {p}");
            Console.ReadKey();
        }
    }
}
