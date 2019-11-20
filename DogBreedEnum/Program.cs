using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogBreedEnum
{   
    enum Breed
    {
        
        Boxer,
        Chihuahua,
        Bulldog

    }
    class Dog
    {
        public static int Count = 0;
        public string name;
        public int age;
        public Breed dogBreed;

        public Dog(string _name, int _age, Breed _breed)
        {
            name = _name;
            age = _age;
            dogBreed = _breed;
            Count++;
        }

        public void PrintDogInfo()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Breed: {dogBreed}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog sass = new Dog("Sass", 10, Breed.Chihuahua);
            sass.PrintDogInfo();

            Dog muks = new Dog("Muks", 2, Breed.Boxer);
            muks.PrintDogInfo();

            Console.WriteLine($"{Dog.Count} has/have been created");

            Console.WriteLine((int)Breed.Bulldog);  //annab indexi nr koha


            Console.ReadLine();
        }
    }
}
