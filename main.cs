using System;
using System.Linq;

namespace DoragonSoruja
{
  public class validPass
  {
    public static string validator(string password)
    {  
        if(password.Length <= 3 || password.Length >= 20)
            return "INVALID";
        
        if(password.Any(x => !char.IsLetter(x) && !char.IsDigit(x)))
            return "INVALID";
            
        if(password.All(x => char.IsLetter(x)) || password.All(x => char.IsDigit(x)))
            return "INVALID";
            
        return "VALID";
    }
  }
}
