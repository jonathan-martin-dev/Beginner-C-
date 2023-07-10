using System;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
      Madlibs
      Author: Jonathan Martinez
      */


        // Let the user know that the program is starting:


        // Let the user know that the program is starting:
        Console.WriteLine("The Program is starting...");

        // Give the Mad Lib a title:
        string title = "Boring Times, Boring Measures";

        Console.WriteLine(title);
        // Define user input and variables:
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        Console.WriteLine("Please declare 3 adjectives.");
        string adjective1 = Console.ReadLine();
        Console.WriteLine("Adjective 1 has been added.");
        string adjective2 = Console.ReadLine();
        Console.WriteLine("Adjective 2 has been added.");
        string adjective3 = Console.ReadLine();
        Console.WriteLine("Adjective 3 has been added.");
        Console.WriteLine("Declare a verb.");
        string verb = Console.ReadLine();
        Console.WriteLine("A verb has been added.");
        Console.WriteLine("Declare a noun.");
        string noun = Console.ReadLine();
        Console.WriteLine("A noun has been added.");
        Console.WriteLine("Declare another noun.");
        string noun2 = Console.ReadLine();
        Console.WriteLine("A noun has been added.");
        Console.WriteLine("Please name an animal.");
        string animal = Console.ReadLine();
        Console.WriteLine("Please name any food.");
        string food = Console.ReadLine();
        Console.WriteLine("Please name any fruit.");
        string fruit = Console.ReadLine();
        Console.WriteLine("Please name any superhero.");
        string superhero = Console.ReadLine();
        Console.WriteLine("Please name any country.");
        string country = Console.ReadLine();
        Console.WriteLine("Please name a dessert.");
        string dessert = Console.ReadLine();
        Console.WriteLine("Add any year.");
        string year = Console.ReadLine();
        // The template for the story:

        string story = $"This morning {name} woke up feeling {adjective1}. 'It is going to be a {adjective2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun}, which made all the {fruit}s very {adjective3}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";


        // Print the story:
        Console.WriteLine(story);


        /* bool beach = true;
        bool city = false;
        bool town = true;
        bool farm = false;

        if (beach)
        {
            city = true;
        }
        else
        {
            city = false;
        } */




    }
}