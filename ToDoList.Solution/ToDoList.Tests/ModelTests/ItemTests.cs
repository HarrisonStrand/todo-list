using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ToDoList.Models;
using System;

namespace ToDoList.Tests
{
  [TestClass]
  public class ItemTests : IDisposable
  {

    public void Dispose()
    {
      Item.ClearAll();
    }

    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    // ItemConstructor = method we're testing
    // CreatesInstanceOfItem = describes behavior we want our method to have
    // Item = the expected return value of the method being tested
    {
      Item newItem = new Item("test"); //pass in "test" as an argument
      Assert.AreEqual(typeof(Item), newItem.GetType());
      // ^^ two new built in methods: typeof (returns data type of a class), GetType() - returns the datatype of a specific obj
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()  // creating a new test method
    {
      //Arrange
      string description = "Walk the dog."; // creates new string "description"
      Item newItem = new Item(description); // create new Item object, passing in "description" as a property of Item
      
      //Act
      string result = newItem.Description;  // record the result of retrieving Description property of newItem
      
      //Assert
      Assert.AreEqual(description, result);  // Confirm description retrieved from Item obj matches description string provided to constructor
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      //Arange
      string description = "Walk the dog.";
      Item newItem = new Item(description);

      //Act
      string updatedDescription = "Do the dishes";
      newItem.Description = updatedDescription;
      string result = newItem.Description;

      //Assert
      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_ItemList()
    {
      //Arrange
      List<Item> newList = new List<Item> { };
      // ^ creates newList, a new empty List for holding Items

      //Act
      List<Item> result = Item.GetAll();
      // ^ we call the static GetAll() method - the value returned is stored in `result`.

      //Assert
      CollectionAssert.AreEqual(newList, result);
      // ^ result should be equal to newList - confirming our GetAll() method returns a list sucessfully.
    }

    [TestMethod]
    public void GetAll_ReturnsItems_ItemList()
    {
      //Arrange
      string description01 = "Walk the dog";
      string description02 = "Wash the dishes";
      Item newItem1 = new Item(description01);
      Item newItem2 = new Item(description02);
      List<Item> newList = new List<Item> { newItem1, newItem2 };
      // arrange both description arguments then create a new Item for each

      //Act
      List<Item> result = Item.GetAll();
      //Create a list containing these Items received from GetAll()

      //Assert
      CollectionAssert.AreEqual(newList, result);
      //assert that the return value of GetAll() should be the same as our manually-constructed newList.
    }
    
  }
}