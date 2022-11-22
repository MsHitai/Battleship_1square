using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_07_Battleship
{
    class Program
    {
        //Define our variable with type and identifier, string means text
        static void Main(string[] args)
        {
            while (true)
            {
                Random rnd = new Random();

                //int ShipSize = rnd.Next(1, 5);

                Console.WriteLine("There is a ship here! Try to hit it!");

                int yShip = rnd.Next(1, 10);

                //int yShip = 2;

                int xShip = rnd.Next(1, 10);

                //int xShip = 4;

               

                //bool missed = false;

                Console.WriteLine("Please enter the x coordinate");
                int xPos = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the y coordinate");
                int yPos = int.Parse(Console.ReadLine());

                for (int y = 0; y < 10; y++)
                {

                    for (int x = 0; x < 10; x++)
                    {

                        if (y == 0 && x != 0)
                        {
                            Console.Write($"[{x}]");
                        }
                        else if (x == 0 && y != 0)
                        {
                            Console.Write($"[{y}]");
                        }
                        else if (x == xPos && x != xShip && y == yPos && y != yShip)
                        {
                            Console.Write("[+]");
                            
                        }
                        else if (x == xPos && x == xShip && y == yPos && y == yShip)
                        {
                            Console.Write("[X]");
                            
                        }
                        else if(x == xShip && y == yShip)
                        {
                            Console.Write("[S]");
                        }
                        else
                        {
                            Console.Write("[ ]");
                        }
                    }
                    Console.WriteLine();
                 }
                Console.WriteLine($"{xShip}, {yShip}");

                if (xShip == xPos && yShip == yPos)
                {
                    Console.WriteLine("You killed it! Good job!");
                }
                else
                {
                    Console.WriteLine("You missed!");
                }
                Console.WriteLine("The ship was at S");
                Console.WriteLine("Do you want try again? Write yes or no");

                string Decision = Console.ReadLine();

                //ToLower takes all capital or non capital letters to make one word that equals "yes" in this case, be it "YeS" or "yeS", it will make it "yes"
                if (Decision.ToLower() == "yes")
                {
                    Console.Clear();

                }
                else
                {
                    break;
                }


            }
        }
    }
}
