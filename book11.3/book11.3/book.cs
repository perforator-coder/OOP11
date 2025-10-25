using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace book11._3
{
    internal class book
    {
        private string title;
        private bool er_title;
        private int pages;
       

        //конструктор
        public book(string title)
        {
            if (string.IsNullOrWhiteSpace(title) == true)
            {
                Console.WriteLine("Название книги не может быть пустым.");
                this.er_title = true;
            }
            else
            {
                this.title = title;
                er_title = false;
            }
        }
        public string getTitle
        {
            get { return title; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) == true)
                {
                    Console.WriteLine("Название книги не может быть пустым.");
                    er_title = true;
                }
                else
                {
                    title = value;
                    er_title = false;
                }
            }
        }
        public int getpages { get; set; } = 1;
        public bool Islong 
        {
            get 
            {
                if (getpages > 300)
                {
                    return true;
                }
                else 
                {
                    return false;
                }
            }
        }

        //действие
        public void info()
        {
            if (er_title == false)
            {
                string tmp_out;
                if (Islong == true)
                {
                    tmp_out = "да";
                }
                else
                {
                    tmp_out = "нет";
                }
                Console.WriteLine($"Книга: {title}, страниц: {getpages},длинная:{tmp_out}");
            }
        }





    }
}
