using System;
using System.Collections.Generic;

public class Kata
{
  public static bool Solution(string str, string ending)
  {
    if (ending.Length > str.Length)
      return false;
    
    var temp = str.ToCharArray();
    var end = ending.ToCharArray();
    Array.Reverse(temp);
    Array.Reverse(end);
    for (var i=0; i < end.Length; i++) {
      if (temp[i] != end[i])
        return false;
    }
    return true;
  }
}
