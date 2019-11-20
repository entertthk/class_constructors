using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskList
{   
    class Task
    {
        
        public string task1;
        
        public Task(string _task1)   //konstruktor
        {
            task1 = _task1;
         
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\demo\taskList.txt";
            List<string> taskList = File.ReadAllLines(filePath).ToList();
            List<Task> listOfTasks = new List<Task>();  //teeb objektide listi

            foreach (string line in taskList)
            {

                Task newPerson = new Task(line);

                listOfTasks.Add(newPerson);
            }

            foreach (Task Task in listOfTasks)
            {
                Console.WriteLine($"{Task.task1}");
            }

            Console.ReadLine();
        }
    }
}
