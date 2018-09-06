using System;
using System.Collections.Generic;


namespace Anagram.Models
{
  public class Word
  {
    private string _input;
    public Word (string input)
    {
      _input = input;
    }
    public char[] GetInput()
    {
      var inputCharacters = _input.ToCharArray();
      char[] sortedCharacter = inputCharacters;
      Array.Sort(sortedCharacter);
      // int inputStringLength = inputCharacters.Length;
      return sortedCharacter;

    }
    public static bool IsAnagram(char[] x, char[] y)
    {
      string stringInput1 = "";
      string stringInput2 = "";
      for (int index = 0; index < x.Length; index++)
    {
        stringInput1 += x[index];
        stringInput2 += y[index];
    }
      if (stringInput1 == stringInput2)
      {
        Console.Write("The words: " + stringInput1 + " " + stringInput2 + " are anagrams!");
        return true;
      }
      else {
        Console.Write("The words: " + stringInput1 + " " + stringInput2 + " are not anagrams!");
        return false;
      }

    }
  }

  public class Program
  {
    static void Main()
    {
      Word newWord = new Word("beard");
      Word anagramWord = new Word("bread");
      char[] x = newWord.GetInput();
      char[] y = anagramWord.GetInput();
      Word.IsAnagram(x, y);

    }
  }
  // int inputStringLength = inputString.Length;
  // char [] inputCharacters = inputString.ToCharArray();
  // char [] inputWord = Array.Sort(inputCharacters);
  //
  // int inputSecondStringLength = inputSecondString.Length;
  // char [] inputSecoondCharacters = inputSecondString.ToCharArray();
  // char [] inputSecondWord = Array.Sort(inputSecondCharacters);

  }
  // public Anagram (string word)
  // {
  //   _word = word;
  // }
