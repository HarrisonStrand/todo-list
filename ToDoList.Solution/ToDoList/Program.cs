using System;
using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome to your ToDo List!");
      Console.WriteLine("Would you like to add an item to your list or view your list? (Add/View/Clear/Quit)");
      string userInput = Console.ReadLine();
      if(userInput == "Add")
      {
        Console.WriteLine("Please enter your description");
        string userDescription = Console.ReadLine();
        Item newItem = new Item(userDescription);
        Program.Main();
      }
      else if (userInput == "View")
      {
      List<Item> result = Item.GetAll();
        if(result.Count < 1)
        {
          Console.WriteLine("These are not the list items you're looking for...");
          Program.Main();
        }
        else
        {
          Console.WriteLine("Here is your list:");
          Item.GetAll().ForEach(i => Console.WriteLine(i.Description));
          Program.Main();
        }      
      }
      else if (userInput == "Clear")
      {
        Console.WriteLine("Clearing your list...");
        Item.ClearAll();
        Program.Main();
      }
      else
      {
        Console.WriteLine("Program is Terminated");
      }
    }
  }
}