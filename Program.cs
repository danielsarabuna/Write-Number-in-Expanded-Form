using System;

public class Program
{  
  public static string ExpandedForm(long num)
  {
    string result = string.Empty;
    long x = 10, c = 1;

    while (num > 0)
    {
      if (c < num)
      {
        long r = num % c;
        num -= r;
        if (r > 0 && result != string.Empty) result = $"{r} + {result}";
        else if (r > 0) result = $"{r}";
      }
      c *= x;
    }
  
    return result;
  }
}