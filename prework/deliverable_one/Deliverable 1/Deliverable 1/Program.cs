using System;
public class Program
{
    public static void Main()
    {
        bool restart = true;

        while (restart)
        {

            Console.Write("How many people are we making PB&J sandwiches for?\n");
            int input = int.Parse(Console.ReadLine());


            Console.WriteLine(input * 2 + " Slices of bread");
            Console.WriteLine(input * 2 + " tablespoons of peanut butter");
            Console.WriteLine(input * 4 + " teaspoons of jelly");
            Console.WriteLine();


            double bread = Convert.ToDouble(input * 0.071429);
            double pb = Convert.ToDouble(input * 0.0625);
            double jelly = Convert.ToDouble(input * 0.083333);
                               

            Console.WriteLine(Math.Ceiling(bread) + " loaves of bread");
            Console.WriteLine(Math.Ceiling(pb) + " jars of peanut butter");
            Console.WriteLine(Math.Ceiling(jelly) + " jars of jelly");
            Console.WriteLine();

            String options1 = "Yes";
            String options2 = "Y";

            Console.Write("Would you like to restart? Enter Y or Yes to continue, or any other key to exit.\n");

            String answer = Console.ReadLine();

            if (answer == options1)
            { restart = true; }

            else if (answer == options2)
            { restart = true; }

            else

            {
                restart = false;
                Console.WriteLine("Goodbye"); 
                Console.ReadKey();
            }
        }
    }
}

