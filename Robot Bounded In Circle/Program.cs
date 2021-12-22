using System;

namespace Robot_Bounded_In_Circle
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      Program p = new Program();
      Console.WriteLine(p.IsRobotBounded("GGLLGG"));
    }


    // https://leetcode.com/problems/robot-bounded-in-circle/
    // https://leetcode.com/problems/robot-bounded-in-circle/discuss/850969/My-Java-Solution-with-the-thought-process
    public bool IsRobotBounded(string instructions)
    {
      int x = 0, y = 0;
      string dir = "North";

      foreach (char c in instructions)
      {
        // Position
        if (c == 'G')
        {
          if (dir == "North")
            y += 1;
          else if (dir == "South")
            y -= 1;
          else if (dir == "East")
            x += 1;
          else
            x -= 1;
        }
        // Directions
        else if (c == 'L')
        {
          if (dir == "North")
            dir = "West";
          else if (dir == "West")
            dir = "South";
          else if (dir == "South")
            dir = "East";
          else
            dir = "North";
        }
        else if (c == 'R')
        {
          if (dir == "North")
            dir = "East";
          else if (dir == "West")
            dir = "North";
          else if (dir == "South")
            dir = "West";
          else
            dir = "South";
        }
      }

      if (x == 0 && y == 0) return true;
      if (dir == "North") return false;
      return true;
    }
  }
}
