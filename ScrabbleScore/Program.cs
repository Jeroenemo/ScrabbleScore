using System;
using ScrabbleScore.Models;

namespace ScrabbleScore
{
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

      Console.WriteLine("Welcome to the Unofficial Scrabble Word Score Calculator.");
      Console.WriteLine("Please enter a word below, and we will output the score for that word:");
      string userInput = Console.ReadLine();
      int wordValue = myWord.Calculate(userInput);
      Console.WriteLine("Your word {0} is worth {1}.", userInput, wordValue);
    }
  }
}