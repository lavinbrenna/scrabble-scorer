using System.Collections.Generic;
using System;
namespace Scrabble.Models
{
  public class Game
  {
    public string Word {get;set;}
    public Game(string word)
    {
      Word = word;
    }
    public static int WordScore(string word)
    {
      string userWord = word.ToUpper();
      char[] userArray = userWord.ToCharArray();
      string OnePoint = "AEIOULRNST";
      string TwoPoints = "DG";
      string ThreePoints = "BCMP";
      string FourPoints = "FHVWY";
      string FivePoints = "K";
      string EightPoints = "JX";
      string TenPoints = "QZ";
      int points = 0;
      foreach(char letter in userWord){
        if(OnePoint.Contains(letter))
        {
          points += 1;
        }
        else if(TwoPoints.Contains(letter) )
        {
          points +=2;
        }
        else if(ThreePoints.Contains(letter))
        {
          points +=3;
        }
        else if(FourPoints.Contains(letter))
        {
          points +=4;
        }else if(FivePoints.Contains(letter))
        {
          points +=5;
        }
        else if(EightPoints.Contains(letter))
        {
          points +=8;
        }
        else if(TenPoints.Contains(letter))
        {
          points +=10;
        }
        else
        {
          points +=0;
        }
      }
      return points;
    }
    // input: wordToScore
    // break down word to letters (array or list)
    // something to track points
    // evaluate each letter using comparisons and if statements
    // depending on letter, add to point value
    // return point value
    // determine how to store letters with associated scores

    // if (1pointArray.Contains(input[i]))
    // {
    //   point += 1;
    // }
    // string[] = {"a,r,r,a,y"};
    // char [] 1pointarray = {A, E, I, O, U, L, N, R, S, T };
    // foreach char in 1pointarray
    //   point +=1



  }
}
