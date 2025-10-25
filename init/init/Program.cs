using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace init
{
    internal class Program
    {
        static void Main(string[] args)
        {
            phone iphone17 = new phone(10,"iphone17",false);
            iphone17.Use();
            iphone17.Use();
            iphone17.Use();
            Console.ReadLine();
           
        }
    }
}
