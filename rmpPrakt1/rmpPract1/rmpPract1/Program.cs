using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rmpPract1
{

    public class Cat
    {
        private string name;
        private double weight;

        public string Name
        {
            get { return name; }
            set
            {
                bool OnlyLetters = true;
                foreach (var ch in value)
                {
                    if (!char.IsLetter(ch))
                    {
                        OnlyLetters = false;
                    }
                }

                if (OnlyLetters)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine($"{value} - неправильное имя!!!");
                }
            }
        }

        public double Weight
        {
            get { return weight; }
            set
            {
                if (value > 0) weight = value;
                else Console.WriteLine("Вес не может быть отрицательным или равным нулю");
            }
        }

        public Cat(string CatName, double CatWeight)
        {
            Name = CatName;
            Weight = CatWeight;
        }

        public void Meow()
        {
            Console.WriteLine($"{name}: МЯЯЯЯУ!!!!");
        }

        public void PrintWeight()
        {
            Console.WriteLine($"Вес {name} - {weight}кг");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите имя кота: ");
            string catName = Console.ReadLine();

            Console.WriteLine("Введите вес кота: ");
            double catWeight = double.Parse(Console.ReadLine());

            Cat cat = new Cat(catName, catWeight);
            cat.Meow();
            cat.PrintWeight();

            Console.ReadKey();
        }
    }
}
