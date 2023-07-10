using System;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
      Password Checker
      Author: Jonathan Martinez
      */

        int minLength = 5;
        string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string lowercase = "abcdefghijklmnopqrstuvwxyz";
        string digits = "0123456789";
        string specialChars = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
        int score = 0;

        Console.WriteLine("Please enter a password");
        string password = Console.ReadLine();

        if (password.Length >= minLength)
        {
            score++;
        }
        if (NewBeginnings.Tools.Contains(password, uppercase))
        {
            score++;
        }
        if (NewBeginnings.Tools.Contains(password, lowercase))
        {
            score++;
        }
        if (NewBeginnings.Tools.Contains(password, digits))
        {
            score++;
        }
        if (NewBeginnings.Tools.Contains(password, specialChars))
        {
            score++;
        }

        switch (score)
        {
            case 5:
            case 4:
                Console.WriteLine("The password is extremely strong");
                break;
            case 3:
                Console.WriteLine("The password is strong");
                break;
            case 2:
                Console.WriteLine("The password is medium");
                break;
            case 1:
                Console.WriteLine("The password is weak");
                break;
            default:
                Console.WriteLine("The password does not meet the standards");
                break;
        }

        Console.WriteLine(score);
    }
}