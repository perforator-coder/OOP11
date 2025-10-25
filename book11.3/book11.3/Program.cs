using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book11._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            book book1 = new book("");
            book1.getpages = 350;
           
            book1.info();
            Console.ReadKey();
        }
    }
}
