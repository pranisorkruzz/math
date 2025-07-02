using System.ComponentModel.Design;
using System.Numerics;
using System.Xml.Linq;

var games = new List<string>();
bool isGameOn = true;
var date = DateTime.Now;

string name = getName();

while (isGameOn)
{
    Console.WriteLine("Choose an option:");
    Console.WriteLine("1 - Addition");
    Console.WriteLine("2 - Subtraction");
    Console.WriteLine("3 - Multiplication");
    Console.WriteLine("4 - Division");
    Console.WriteLine("5 - View History");
    Console.WriteLine("6 - Quit");

    var choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            additionGame("Addition Game");
            break;
        case "2":
            substractionGame("Subtraction Game");
            break;
        case "3":
            multiplicationGame("Multiplication Game");
            break;
        case "4":
            DivsionGame("Division Game");
            break;
        case "5":
            getGames();
            break;
        case "6":
            isGameOn = false;
            break;
    }
}

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
    foreach (var game in games)
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
    games.Add($"{DateTime.Now}-multiplication score: {score}");
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
    games.Add($"{DateTime.Now}-division score: {score}");
}