using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;


namespace System.Runtime.CompilerServices 
{
    internal static class IsExternalInit { }
}
namespace init
{
    
    internal class phone
    {
        
        private int batorry;
        private string brand;
        private bool er_bat;

        //конструктор
        public phone(int batt, string brand, bool er)
        {
            if (batt < 0 || batt > 100)
            {
                Console.WriteLine("Ошибка: число не в диапозоне.");
                er_bat = true;
            }
            else
            {
                this.batorry = batt;
                this.brand = brand;
                this.er_bat = er;
            }
        }
            

        //свойства
        public int batorlevel
        {
            get { return batorry; }
            set
            {
                if (value < 0 || value > 100)
                {
                    Console.WriteLine("Ошибка: число не в диапозоне.");
                    er_bat = true;
                }
                else
                {
                    er_bat = false;
                    batorry = value;
                }
            }
        }
        public int brandget
        {
            get;
            init;
        }

        public void Use()
        {
            if (batorry > 0 && er_bat == false)
            {
                Console.WriteLine($"Телефон {brand}: заряд {batorry}%");
                batorry -= 10;
            }
            else if (batorry <= 0 && er_bat == false)
            {

                batorry = 0;
                Console.WriteLine($"Телефон {brand}: заряд {batorry}% -- разряжен.");

            }
            else { }
        }
    }
}
