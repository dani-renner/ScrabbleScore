using System;
using System.Collections.Generic;
using ScrabbleScore.Models;

namespace ScrabbleScore
{
    public class Program
    {
      static void Main()
      {
        Console.WriteLine("Please enter a word. (No numbers or characters.)");
        string word = Console.ReadLine();
        Scrabble newScrabble = new Scrabble(word);
        try
        {
          Console.WriteLine("Points = {0}",newScrabble.Points());
        } 
        catch(Exception ex)
        {
          Console.WriteLine("Error! Please enter a single word with no numbers or characters.");

        }

        Main();

      }
    }
}