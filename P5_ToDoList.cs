using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects
{
    internal class Project5
    {

        static void Main(string[] args)
        {
            List<string> tasks = new List<string>();
            char choice;
            string append, remove = string.Empty;

            Console.WriteLine("Welcome to the to-do list!");
            display();
            choice = char.Parse(Console.ReadLine());

            while (choice != 'e')
            {

                switch (choice)
                {
                    case '1':
                        viewList(tasks);
                        break;
                    case '2':
                        appendTask(tasks);
                        break;
                    case '3':
                        removeTask(tasks);
                        break;
                    default:
                        Console.WriteLine("Error, please try again.");
                        break;
                }
                display();
                try
                {
                    choice = char.Parse(Console.ReadLine());
                } catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                    break;
                }
                Console.WriteLine();
            }
            Console.WriteLine("Exited program.");
        }

        static void viewList(List<string> tasks)
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("You currently have no tasks.");
            }
            else
            {
                Console.WriteLine("To-do:");
                foreach (string task in tasks)
                {
                    Console.WriteLine("- " + task);
                }
            }
        }

        static void display()
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("\nWhat would you like to do?\n" +
                                 "1. View List\n" +
                                 "2. Add task to list\n" +
                                 "3. Remove task from list\n" +
                                 "Press 'e' to quit.");
        }

        static List<string> appendTask(List<string> tasks)
        {
            Console.Write("Add a task to your list: ");
            string append = Console.ReadLine();
            tasks.Add(append);

            return tasks;
        }

        static List<string> removeTask(List<string> tasks)
        {
            Console.Write("Enter task you would like to remove: ");
            string remove = Console.ReadLine();
            if (tasks.Contains(remove)) {
                tasks.Remove(remove);
                Console.WriteLine("Successfully removed " + remove);
            } else Console.WriteLine(remove + " does not exist.");

            return tasks;
        }
    }
}
