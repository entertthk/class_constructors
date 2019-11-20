using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_Enums
{
    class Animal
    {
        public string name;
        public int age;
        public int levelOfHappiness;

        public void PrintBasicInfo()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Level of happiness: {levelOfHappiness}");
        }
    }
    class Dog : Animal
    {
        public int numberOfBarks = 0;

        public void WaveTail()
        {
            Console.WriteLine($"{name} Wave tail!");
            levelOfHappiness++; // +1
        }
        public void Bark()
        {
            Console.WriteLine("Woof!");
            numberOfBarks++;
        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Dog Rex = new Dog();
            Rex.name = "Rex";
            Rex.age = 5;
            Rex.levelOfHappiness = 0;

            for (int i=0; i<12; i++)
            {
                Rex.WaveTail();
                if (Rex.levelOfHappiness % 3 == 0) //jääk on 0, 6/3=0; 5/3=2
                {
                    Rex.Bark();
                }
            }

            Rex.PrintBasicInfo();
            Console.WriteLine($"{Rex.name} has barked {Rex.numberOfBarks} times");




            Console.ReadLine();
        }
    }
}
