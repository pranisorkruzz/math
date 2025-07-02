using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math
{
    internal class Menu
    {
        void Menu(string name)
        {
            do
            {
                Console.WriteLine($"hello {name} it is {date} right now and this is a math game");
                Console.WriteLine("Please select the mode to paly:");
                Console.WriteLine("");
                Console.WriteLine("v.VIEW GAME HISTORY");
                Console.WriteLine("a.ADDTION");
                Console.WriteLine("b.SUBSTRACTION");
                Console.WriteLine("c.MULTIPLICATION");
                Console.WriteLine("d.DIVISION");
                Console.WriteLine("q.QUIT THE PROGRAM");

                Console.WriteLine("--------------------------------");

                var gameSelected = Console.ReadLine();

                switch (gameSelected.Trim().ToLower())
                {
                    case "v":
                        getGames();
                        break;
                    case "a":
                        additionGame("addition game selected");
                        break;

                    case "b":
                        substractionGame("substraction game selected");
                        break;

                    case "c":
                        multiplicationGame("multipication game selected");
                        break;

                    case "d":
                        DivsionGame("division game selected");
                        break;

                    case "q":
                        Console.WriteLine("Exiting..............");
                        isGameOn = false;
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid input");
                        break;

                }
            } while (isGameOn);
        }

    }
}
