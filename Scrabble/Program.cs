using System;

namespace Scrabble.Models
{
  public class Program
  {
    public static void Main()
    {
      bool keepGoing = true;
      while (keepGoing == true) {
        Console.WriteLine("Would you like to enter a word? Yes or No");
        string userResponse = Console.ReadLine().ToLower();
        if (userResponse == "yes")
        {
          Console.WriteLine("Please enter a word to determine it's Scrabble score");
          string inputWord = Console.ReadLine();
          Game newGame = new Game(inputWord);
          int wordScore = Game.WordScore(inputWord);
          Console.WriteLine("Your word is worth "+ wordScore + " points!");
        }
        else if (userResponse == "no")
        {
          keepGoing = false;
        }
        else
        {
          Console.WriteLine("That is not a valid response");
        }
      }
    }
  }
}