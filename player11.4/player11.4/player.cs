using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices
{
    internal static class IsExternalInit { }
}
namespace player11._4
{
    internal class player
    {
        private int level;
        private int healt;
        private bool er_level;
        private bool er_healt;

        //конструктор
        public player(string name,int level,int healt)
        {
            this.Name = name;
            this.cetlevel = level;
            this.cethelt = healt;
        }
        //свойства
        public int cetlevel
        {
            get { return level; }
            set
            {
                if (value < 1 || value > 100)
                {
                    Console.WriteLine("Число уровня не вдиапозоне.");
                    er_level = true;
                }
                else
                {
                    er_level = false;
                    level = value;
                }
            }
        }
        public int cethelt
        {
            get { return healt; }
            set
            {
                if (value < 1 || value > 100)
                {
                    Console.WriteLine("Число здоровья не в диапозоне.");
                    er_healt = true;
                }
                else
                {
                    er_healt = false;
                    healt = value;
                }
            }
        }
         public bool isalive
        {
            get
            {
                if (healt > 0) { return true; }
                else { return false; }
            }
        }
        
        public string Name { get; init; }

        public void TakeDM(int dm)
        {

            if (healt > 0 && er_healt == false && er_level == false)
            {
                healt -= dm;

                string tmp_out;
                if (isalive == true) { tmp_out = "да"; }
                else { tmp_out = "нет"; }
                Console.WriteLine($"Игрок:{Name},уровень:{level},здоровье:{healt},жив:{tmp_out}.");
            }
            else { }
        }

    }
}
