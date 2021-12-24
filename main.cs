using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MainClass
{
  static List<char> chars = new List<char>();

  public static void Main (string[] args)
  {
    int numberOfTry;
    int restart = 0;
    string start;
    
    Console.WriteLine("How many nitro codes are we generating?");
    numberOfTry = Convert.ToInt32(Console.ReadLine());

    if(numberOfTry > 0)
    {
      Console.WriteLine("You have chosen " + numberOfTry + " unchecked nitros.");

      Console.WriteLine("Write Start to start the gen");
      
      start = Convert.ToString(Console.ReadLine());

      while(start != "Start")
      {
        Console.WriteLine("This command is invalid. Please retry...");
        start = Convert.ToString(Console.ReadLine());
      }

      if(start == "Start");
      {
        Console.Clear();

        while(restart < numberOfTry)
        {
        AddChars(ref chars);
        int length = 15;
      
        Console.WriteLine("https://discordapp.com/gifts/" + generatePassword(length));
        restart++;
        }
      }

      return;
    }

    while(numberOfTry < 1)
    {
      Console.WriteLine("This value is incorrect. please retry");
      numberOfTry = Convert.ToInt32(Console.ReadLine());
    }

    if(numberOfTry > 0)
    {
      Console.WriteLine("You have chosen " + numberOfTry + " unchecked nitros.");

      Console.WriteLine("Waiting until the command 'Start' is writen...");
      
      start = Convert.ToString(Console.ReadLine());

      while(start != "Start")
      {
        Console.WriteLine("This command is invalid. Please retry...");
        start = Convert.ToString(Console.ReadLine());
      }

      if(start == "Start");
      {
        Console.Clear();
        
        while(restart < numberOfTry)
        {
        AddChars(ref chars);
        int length = 16;
      
        Console.WriteLine("https://discordapp.com/gifts/" + generatePassword(length));
        restart++;
        }
      }
    }
  }

  static string generatePassword(int length)
  {
    StringBuilder sb = new StringBuilder();
    var rand = new Random();

    for(int i = 0; i < 30; i++)
    {
      sb.Append(chars[rand.Next(0, chars.Count)]);
    }

    return sb.ToString();
  }

  static void AddChars(ref List<char> chars)
  {
    for(char c = 'a'; c <= 'z'; c++)
    {
      chars.Add(c);
    }
    for(char c = 'A'; c <= 'Z'; c++)
    {
      chars.Add(c);
    }
    for(char c = '0'; c <= '9'; c++)
    {
      chars.Add(c);
    }
  }
}
