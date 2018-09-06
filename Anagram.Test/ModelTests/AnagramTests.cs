using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram.Models;

namespace Anagram.Tests
{
  [TestClass]
  public class AnagramTest
  {
    // [TestMethod]
    // public void GetInput_ReturnsInput_String()
    // {
    //   //Arrange
    //   string input = "bread";
    //   Word newInput = new Word(input);
    //
    //   //Act
    //   char[] result = newInput.GetInput();
    //
    //   //Assert
    //   Assert.AreEqual(input, result);
    // }
    // [TestMethod]
    // public void GetInput_ReturnsCharArray_True()
    // {
    //   //Arrange
    //   string input = "bread";
    //   Word newInput = new Word(input);
    //   char[] breadArray = new char[5] {'b','r','e','a','d'};
    //   //Act
    //   char[] resultArray = newInput.GetInput();
    //
    //   //Assert
    //   CollectionAssert.AreEqual(breadArray, resultArray);
    // }
    [TestMethod]
    public void GetArraySorted_ReturnsSortedCharArray_True()
    {
      //Arrange
      string input = "bread";
      Word newInput = new Word(input);

      //Act
      char[] resultArray = newInput.GetInput();
      char[] sortedArray =  {'a','b','d','e','r'};
      //Assert
      CollectionAssert.AreEqual(sortedArray, resultArray);
    }
    [TestMethod]
    public void GetArraySorted_CompareToCharArray_True()
    {
      //Arrange
      Word newInput = new Word("bread");
      Word newInput2 = new Word("beard");
      //Act
      char[] resultArray = newInput.GetInput();
      char[] sortedArray2 =  newInput2.GetInput(); 
      bool isAnagram = Word.IsAnagram(resultArray, sortedArray2);

      //Assert
      Assert.AreEqual(isAnagram, true);
    }
  }
}
