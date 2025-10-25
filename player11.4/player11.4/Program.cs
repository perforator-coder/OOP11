using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace player11._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            player player1 = new player("Олег", 5, 40);
            player1.TakeDM(20);
            player1.TakeDM(20);
            player player2 = new player("", 0, 0);
            Console.ReadKey();
        }
    }
}
