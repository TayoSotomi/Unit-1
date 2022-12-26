using System;
public class Program
{
    public static void Main()
    {
        bool restart = false;

        while (!restart) 
        {

            Console.Write("How many people are we making PB&J sandwiches for?\n");
            int input = int.Parse(Console.ReadLine());


            Console.WriteLine(input * 2 + " Slices of bread");
            Console.WriteLine(input * 2 + " tablespoons of peanut butter");
            Console.WriteLine(input * 4 + " teaspoons of jelly");
            Console.WriteLine();


            double bread = Convert.ToDouble(input * 2 / 28);
            double pb = Convert.ToDouble(input * 2 / 32);
            double jelly = Convert.ToDouble(input * 4 / 48);


            Console.WriteLine(Math.Round(bread, 2) + " loaves of bread");
            Console.WriteLine(Math.Round(pb, 2) + " jars of peanut butter");
            Console.WriteLine(Math.Round(jelly, 2) + " jars of jelly");
            Console.WriteLine();

            String options1 = "Yes";
            String options2 = "Y";

            Console.Write("Would you like to restart? Enter Y or Yes to continue, or any other key to exit.\n");

            String answer = Console.ReadLine();
       
             if (answer == option1)
              { restart = true; }

             else if (answer == options2)
              { restart = true; }

             else

              { Console.WriteLine("Goodbye"); } 
        }
    }
}

    



    
       
        
       
         
           
        
    
         
  
