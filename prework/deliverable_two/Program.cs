using System;

public class Program
{
    public static void Main(string[] args)
    {
        
        double PriceCoffee = 1.50;
        double PriceWater = 0.5;

        Console.Write("Hello welcome! What is your party size?\n");
        int welcome = int.Parse(Console.ReadLine());

        if (welcome >= 1 && welcome <= 6)
        {

            { Console.WriteLine("A table for " + welcome + " ! Please follow me and take a seat.Let's get everyone started with some drinks. We've got water or coffee.\n"); }


            int Welcome = welcome;

            for (Welcome = welcome; Welcome >= 1; Welcome--)
            {
                String[] drinks = { "water", "coffee" };

                { Console.Write("Alright, water or coffee?\n"); }
                String drinksOrder = Console.ReadLine();


                bool menu = false;
                for (int i = 0; i < drinks.Length; i++)
                {
                    if (drinksOrder == drinks[i])
                    {
                        menu = true;
                    }

                }
                if (menu == true)
                {
                    int countCoffee = 0;
                    for (int i = 1; i == drinks.Length; i += 1)
                    {

                        int CountCoffee = countCoffee += i;
                    }

                    int countWater = 0;
                    for (int i = 0; i < drinks.Length; i += 1)
                    { countWater = countWater += i; }


                    double costCoffee = PriceCoffee * countCoffee;

                    double costWater = PriceWater * countWater;

                    double buffet = 9.99;

                    if (Welcome <= 1)
                    {

                        Console.WriteLine();

                        { Console.WriteLine("okay, so that's " + countCoffee + "  coffee(s) and " + countWater + "  bottle(s) of water. I'll be right back. Feel free to grab your food!\n"); }

                        double total = buffet + costCoffee + costWater;

                        Console.WriteLine();

                        { Console.WriteLine("Here is your bill! Total price: $" + total); }
                    }

                }


                else

                {
                    Console.WriteLine("Sorry, we dont have that. Do you care for something else");
                }

            }


        }

        else
        {
            Console.WriteLine("Oh sorry, can only seat parties up to 6. Have a nice day.\n");
        }


    }

}








