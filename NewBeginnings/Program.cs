using System;

internal class Program
{
    private static void Main(string[] args)
    {
        //Declaring a variable
        // int num1;
        //Assign variable
        //num1 = 13;
        //declaring and initializing variable
        //int num2 = 23;
        //int sum = num1 + num2;

        /* Console.WriteLine(sum);

        float f1 = 3.145678f;
        float f2 = 2.5423f;

        float fDiv = f1 / f2;
        Console.WriteLine(fDiv);*/

        string myname = "Jon";
        string message = "My name is " + myname;

        string capsMessage = message.ToUpper();

        Console.WriteLine(capsMessage);
        Console.Read();

    }
}