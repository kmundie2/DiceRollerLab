

static void DiceProject()
{
    
}

bool isDataValid = true;
    int numberOfSides = 0;
    int dice1;
    int dice2;
    int total;
    string answer;
do
{
    Console.WriteLine("Please enter the number of sides on a pair of dice: ");
    string userInput;
    userInput = Console.ReadLine();

    try 
    {
        numberOfSides = int.Parse(userInput);
        isDataValid = true;
        if (numberOfSides < 1)
        {
            bool isGreaterThanZero = true;
            isDataValid = false;
            Console.WriteLine("You did not enter a valid value. Please try again.");
        }
        continue;
    }
    catch (FormatException)
    {
        Console.WriteLine("You did not enter a valid value. Please try again.");
        isDataValid = false;
    }

} while (isDataValid == false);

Random randomNumber = new Random();

do
{
    Console.WriteLine("Please press 'ENTER' to roll the dice.");
    Console.ReadKey();

    dice1 = randomNumber.Next(1, numberOfSides + 1);
    dice2 = randomNumber.Next(1, numberOfSides + 1);

    total = dice1 + dice2;

    Console.WriteLine($"You rolled a {dice1} and a {dice2}. The total is {total}.");

    if (numberOfSides == 6)
    {
        if (dice1 == 1 && dice2 == 1)
        {
            Console.WriteLine("Snake Eyes!");
        }
        else if ((dice1 == 1 && dice2 == 2) || (dice1 == 2 && dice2 == 1))
        {
            Console.WriteLine("Ace Deuce!");
        }
        else if (dice1 == 6 && dice2 == 6)
        {
            Console.WriteLine("Box Cars!");
        }
        else if (total == 7 || total == 11)
        {
            Console.WriteLine("You win!");
        }
        else if (total == 2 || total == 3 || total == 12)
        {
            Console.WriteLine("Craps!");
            Console.WriteLine("You lose!");
        }
    }
    Console.WriteLine("Do you want to roll the dice again? (y/n)");
    answer = Console.ReadLine();

} while (answer.ToLower() == "y");
    Console.WriteLine("Goodbye.");
Console.ReadKey();


