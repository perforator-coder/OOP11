using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product11._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            product cheese = new product(1000, 55);
            cheese.Name = "сыр";
            cheese.Show();
            cheese.cetdiscount = 25;
            cheese.Show();
            cheese.cetprice = -1;
            cheese.Show();
            Console.ReadKey();
        }
    }
}
