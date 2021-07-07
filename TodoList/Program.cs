using System;

namespace TodoList
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Prompt user for number of tasks to carry out
                Console.Write("How many tasks do you want to do? ");
                string listNo = Console.ReadLine();
                int listNumber = Convert.ToInt32(listNo);

                // Use listNumber to create array with number of list
                string[] todoItems = new string[listNumber];

                // Use loop to input list items into todoList array
                for (int i = 0; i < todoItems.Length; i++)
                {
                    Console.Write("Enter list item: ");
                    todoItems[i] = Console.ReadLine();
                }

                // List out list items inside todoList array
                Console.WriteLine("Here are your tasks to-do!");
                foreach (var item in todoItems)
                {
                    Console.WriteLine(item);
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine($"FormatException Handler: {e.Message}");
                Console.WriteLine("Please enter a number");
            }
        }
    }
}
