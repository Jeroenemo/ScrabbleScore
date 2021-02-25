using System;

namespace Scrabble
{
  public class Score
  {
    
    private int _score;

    public void Calculate(string word)
    {
      int wordLength = word.Length;
      char[] letterArray;
      // int score = 0;

      letterArray = word.ToCharArray();

      for (int i = 0; i < wordLength; i++)
      {
        Console.WriteLine("Index: {0} Character: {1}", i, letterArray[i]);
      }

    }
  }
  public class Program
  {
    public static void Main()
    {
      // Create a function that accepts a string word as parameter
      // Function will then break string parameter down into an array of variable string.Length
      // array of Characters
      // array will be iterated over, comparing each character to check the value of said character
      // Variable int will store the score, score will be += the value
      // function returns int score of the word
      Score myWord = new Score();

      myWord.Calculate("hello");
    }
  }
}