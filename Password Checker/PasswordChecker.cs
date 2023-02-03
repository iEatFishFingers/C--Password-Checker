using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
  int minLength = 8;
  string uppercase, lowecase, digits;
  string specialChars = "!£$%^&*()";
  string listNumbers = "1234567890";

  Console.WriteLine("Please enter a pasword");
  string password = Console.ReadLine();

  int score = 0;
  int passlen = password.Length;
  if(passlen >= minLength){
    score++;
  }
  if (Tools.Contains(password, password.ToUpper())){
    score++;
  }
  if (Tools.Contains(password, password.ToLower())){
    score++;
  }
  if (Tools.Contains(password, listNumbers)){
    score++;
  }
  if (Tools.Contains(password, specialChars)){
    score++;
  }

  switch (score){
    case 1:
      Console.WriteLine("Password is weak");
      break;
    case 2:
      Console.WriteLine("Password is medium");
      break;
    case 3:
      Console.WriteLine("Password is strong");
      break;
    case 4:
      Console.WriteLine("Password extremly storng");
      break;
    case 5:
      Console.WriteLine("Password extremly storng");
      break;
  }
 


    }
  }
}
