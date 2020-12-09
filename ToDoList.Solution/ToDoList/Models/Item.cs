using System.Collections.Generic;  // the directive

namespace ToDoList.Models
{
  public class Item
  {
    // below: declares a constructor that takes a description as a parameter and creates a Description property.
    public string Description { get; set; }
    private static List<Item> _instances = new List<Item> {}; 
    // ^ _instance is a new variable to the class Item 
    // ^^ best practices of encapsulation = this var private --> needs to be _camelCase  
    // ^^^ variable is **static** b/c info held is related to *entire* class, not just a single instance of Item
    public Item(string description)
    {
      Description = description;
      _instances.Add(this); //_instances is a static variable // `this` is the ref to the obj being actively created, similar to JS
      // Each time we call our constructor, it will create a new Item and add it to _instances
    }
    
    public static List<Item> GetAll() // static must be delared b/c variable is static
    {
      return _instances;  // returns private _instances field variable
    }
    //^ to call the above, do `Item.GetAll()`
  
    public static void ClearAll()
      {
        _instances.Clear();
      }

  }
}