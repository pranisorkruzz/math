using System.ComponentModel.Design;
using System.Numerics;
using System.Xml.Linq;
using math;

var games = new List<string>();
bool isGameOn = true;
var date = DateTime.Now;

var menu = new Menu();
string name = getName();
Menu(name);

string getName()
{
    Console.WriteLine("enter your name:");
    var name = Console.ReadLine();
    return name;
}


void getGames()
{
    Console.WriteLine("------------------");
    Console.WriteLine("Game history:");
    foreach(var game in games)
    {
        Console.WriteLine(game);
    }
    Console.WriteLine("press any key to continue");
    Console.ReadKey();
    Console.Clear();
}

void additionGame(string message)
{
    Console.WriteLine(message);

    var random = new Random();
    int firstNumber;
    int secondNumber;
    int i;
    int score = 0;

    for (i = 1; i <= 5; i++)
    {
        firstNumber = random.Next(1, 99);
        secondNumber = random.Next(1, 99);

        Console.WriteLine($"{firstNumber} + {secondNumber} :");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber + secondNumber)
        {
            Console.WriteLine("congrats u got it right");
            score++;
        }
        else
        {
            Console.WriteLine("wrong answer");
        }
        Console.WriteLine("press any key to continue...");
        Console.ReadKey();
        Console.Clear();
    }
    Console.WriteLine($"the game is over your final score is : {score}");
    Console.ReadKey();

    games.Add($"{DateTime.Now}-Addition score: {score}");
}



void substractionGame(string message)
{
    Console.WriteLine(message);

    var random = new Random();
    int firstNumber;
    int secondNumber;
    int i;
    int score = 0;

    for (i = 1; i <= 5; i++)
    {
        firstNumber = random.Next(1, 99);
        secondNumber = random.Next(1, 99);

        Console.WriteLine($"{firstNumber} - {secondNumber} :");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber - secondNumber)
        {
            Console.WriteLine("congrats u got it right");
            score++;
        }
        else
        {
            Console.WriteLine("wrong answer");
        }
        Console.WriteLine("press any key to continue...");
        Console.ReadKey();
        Console.Clear();
    }
    Console.WriteLine($"the game is over your final score is : {score}");
    Console.ReadKey();
    games.Add($"{DateTime.Now}-substraction score: {score}");

}
void multiplicationGame(string message)
{
    Console.WriteLine(message);

    var random = new Random();
    int firstNumber;
    int secondNumber;
    int i;
    int score = 0;

    for (i = 1; i <= 5; i++)
    {
        firstNumber = random.Next(1, 99);
        secondNumber = random.Next(1, 99);

        Console.WriteLine($"{firstNumber} * {secondNumber} :");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber * secondNumber)
        {
            Console.WriteLine("congrats u got it right");
            score++;
        }
        else
        {
            Console.WriteLine("wrong answer");
        }
        Console.WriteLine("press any key to continue...");
        Console.ReadKey();
        Console.Clear();
    }
    Console.WriteLine($"the game is over your final score is : {score}");
    Console.ReadKey();
    games.Add($"{DateTime.Now}-substraction score: {score}");
}
void DivsionGame(string message)
{
    Console.WriteLine(message);

    var random = new Random();
    int firstNumber;
    int secondNumber;
    int i;
    int score = 0;

    for (i = 1; i <= 5; i++)
    {

        do
        {
            firstNumber = random.Next(1, 99);
            secondNumber = random.Next(1, 99);
        } while (firstNumber % secondNumber != 0);


        Console.WriteLine($"{firstNumber} / {secondNumber} :");
        var result = Console.ReadLine();


        if (int.Parse(result) == firstNumber / secondNumber)
        {
            Console.WriteLine("congrats u got it right");
            score++;
        }
        else
        {
            Console.WriteLine("wrong answer");
        }
        Console.WriteLine("press any key to continue...");
        Console.ReadKey();
        Console.Clear();
    }
    Console.WriteLine($"the game is over your final score is : {score}");
    Console.ReadKey();
    games.Add($"{DateTime.Now}-substraction score: {score}");
}


