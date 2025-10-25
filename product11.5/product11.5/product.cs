using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product11._5
{
    internal class product
    {
        private int price;
        private bool er_prise;
        private int discount;
        private bool er_discount;

        //конструктор
        public product(int prise,int discount)
        { 
            this.cetprice = prise;
            this.cetdiscount = discount;
        }

        //свойства
        public int cetprice
        {
            get { return price; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Цена не может быть меньше или равно нулю.");
                    er_prise = true;
                }
                else
                {
                    er_prise = false;
                    price = value;
                }
            }
        }

        public int cetdiscount
        {
            get { return discount; }
            set
            {
                if (value < 0 || value > 101)
                {
                    Console.WriteLine("Discount не в диапозене 0-100 включительно.");
                    er_discount = true;
                }
                else
                { 
                    er_discount = false;
                    discount = value;
                }
            }
        }

        public int finalprise
        {
            get
            {
                int tmp = price - price * discount/100;
                return tmp;
            }
        }

        public string Name { get; set; } = "Без названия";


        //действие
        public void Show()
        {
            if (er_discount == false && er_prise == false)
            {
                Console.WriteLine($"{Name}:{finalprise} (Скидка:{discount}%)");
            }
        }

    }
}
