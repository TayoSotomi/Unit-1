using System;
public class Program
{
    public static void Main()
    {
        bool restart = false;

        do
        {

            Console.Write("How many people are we making PB&J sandwiches for?\n");
            int input = int.Parse(Console.ReadLine());

            {
                Console.WriteLine(input * 2 + " Slices of bread");
                Console.WriteLine(input * 2 + " tablespoons of peanut butter");
                Console.WriteLine(input * 4 + " teaspoons of jelly");
                Console.WriteLine();
            }

            double bread = Convert.ToDouble(input * 2 / 28);
            double pb = Convert.ToDouble(input * 2 / 32);
            double jelly = Convert.ToDouble(input * 4 / 48);

            {
                Console.WriteLine(Math.Round(bread, 2) + " loaves of bread");
                Console.WriteLine(Math.Round(pb, 2) + " jars of peanut butter");
                Console.WriteLine(Math.Round(jelly, 2) + " jars of jelly");
                Console.WriteLine();
            }
            String[] option = {"Y","Yes"};

            { Console.Write("Would you like to restart? Enter Y or Yes to continue, or any other key to exit.\n"); }

            var answer = Console.ReadLine();

            for (int i = 1; i < 2; i++)
            {
                if (answer == option[i])
                    restart = true;

            }

        }
        while (!restart);
        

         Console.WriteLine("Goodbye!"); 
        
       
         
           
        
    }
}         
  
