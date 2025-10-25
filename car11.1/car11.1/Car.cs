using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car11._1
{
    internal class Car
    {
        private int speed;
        private string name;
        private bool er_speed;
        public Car(int speed,string model)
        {

            if (speed < 0 || speed> 301)
            {
                Console.WriteLine($"Скорость не может быть {speed} км/ч");
                this.er_speed = true;
            }
            else
            {
                this.speed = speed;
                this.er_speed = false;
            }
            if (String.IsNullOrWhiteSpace(model))
            {
                this.name = "unknow";
            }
            else
            {
                this.name = model;
            }

        }
     

        //свойство скорости
        public int getSpeed
        {
            get {  return speed; }
            set 
            {
                if (value < 0 || value > 301)
                {
                    Console.WriteLine($"Скорость не может быть {value} км/ч");
                    er_speed = true;
                }
                else
                {
                    speed = value;
                    er_speed = false;
                }
            }
        }
        // свойство модели
        public string modelset
        {
            
            get { return name; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    name = "unknow";
                }
                else
                {
                    name = value;
                }
            }
        }
        public void Drive()
        {
            if (er_speed == true) { return; }
            Console.WriteLine($"{name} едет со скоростью {speed} КМ/Ч.");
        }
    }
}
