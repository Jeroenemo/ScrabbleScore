using System;
using System.Collections.Generic;

namespace ScrabbleScore.Models
{
  public class Score
  {
    public static Dictionary <char, int> letters = new Dictionary<char, int>() 
    {
      {'A',1},{'B',3},{'C',3},{'D',2},{'E',1},{'F',4},{'G',1},{'H',4},{'I',1},{'J',8},{'K',5},{'L',1},{'M',3},{'N',1},{'O',1},{'P',3},{'Q',10},{'R',1},{'S',1},{'T',1},{'U',2},{'V',4},{'W',4},{'X',8},{'Y',4},{'Z',10}
    };
    public int Calculate(string word)
    {
      int wordLength = word.Length;
      char[] letterArray;
      int score = 0;

      letterArray = word.ToUpper().ToCharArray();

      for (int i = 0; i < wordLength; i++)
      {
        if (letters.ContainsKey(letterArray[i]))
        {
          score += letters[letterArray[i]];
        }
      }

      return score;
    }

    // public static void ClearAll()
    // {

    // }
  }
}