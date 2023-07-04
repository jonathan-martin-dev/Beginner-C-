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

        /* string myname = "Jon";
        string message = "My name is " + myname;

        string capsMessage = message.ToUpper();
        string lowercaseMessage = message.ToLower();

        Console.WriteLine(capsMessage);
        Console.WriteLine(lowercaseMessage);
        Console.Read(); */

        /* string name = "Jon";
        string name2 = "Jack";
        int age = 35;
        int age2 = 55;

        if (age < age2)
        {
            Console.WriteLine($"{name} is younger than {name2}");
        }
        else
        {
            Console.WriteLine("There is no spoon");
        }
        string sentence = $"{name} is {age} years old";
        Console.WriteLine(sentence); */

        // dna strand
        string startStrand = "ATGCGATGAGCTTAC";

        // find location of "tga"
        int tga = startStrand.IndexOf("TGA");

        // start point and stop point variables
        int startPoint = 0;
        int length = tga + 3;

        // define final strand
        string dna = startStrand.Substring(startPoint, length);

        // DNA mutation search
        Console.WriteLine(dna);
        Console.WriteLine(dna[3]);

    }
}