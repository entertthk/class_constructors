using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocConstructor
{
    class Animal
    {
        public static int Count = 0;  //counter
        
        public string name;
        public string color;
        
        public void PrintBasicInfo()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Color: {color}");
        }
    }

    class Dog : Animal
    {
        public string breed;

        public Dog(string _name, string _color, string _breed) //määra väärtused/omadused
        {
            name = _name;
            color = _color;
            breed = _breed;

            Count++;

            Console.WriteLine("A dog has been created");
        }
        public void PrintInfoAboutDog()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Color: {color}");
            Console.WriteLine($"Dogs breed: {breed}");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog rex = new Dog("Rex", "black and white", "bulldog" );
            rex.PrintInfoAboutDog();

            Console.WriteLine($"{Animal.Count} has/have been created");

            Console.ReadLine();
        }
    }
}
