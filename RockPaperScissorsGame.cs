string Rock = "Rock";
string Paper = "Paper";
string Scissors = "Scissors";

int counter = 1;
int winsCount = 0;
Console.WriteLine("Welcome! You have 3 games VS AI of Rock Paper Scissors.");
await Task.Delay(1500);

while (counter < 4)
{
    await Task.Delay(1000);
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"Game [{counter}/3]");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("Choose [r]ock, [p]aper or [s]cissors: ");

    //Adding playerMove + logic

    string playerMove = Console.ReadLine();
    switch (playerMove)
    {
        case "r":
        case "rock":
        case "Rock":
        case "ROCK":
            playerMove = Rock;
            break;

        case "p":
        case "paper":
        case "Paper":
        case "PAPER":
            playerMove = Paper;
            break;

        case "s":
        case "scissors":
        case "Scissors":
        case "SCISSORS":
            playerMove = Scissors;
            break;

        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid input. Try Again...");
            continue;
    }

    //Adding ComputerMove + logic

    string computerMove = "";
    Random random = new Random();
    int computerRandomNumber = random.Next(1, 4);

    switch (computerRandomNumber)
    {
        case 1:
            computerMove = Rock;
            break;
        case 2:
            computerMove = Paper;
            break;
        case 3:
            computerMove = Scissors;
            break;
    }
    await Task.Delay(1500);
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine($"The computer chose {computerMove}.");
    //Implementing win/draw/lose logic

    await Task.Delay(1000);
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Calculating result...");

    if ((playerMove == Rock && computerMove == Scissors) || (playerMove == Paper && computerMove == Rock)
        || playerMove == Scissors && computerMove == Paper)
    {
        await Task.Delay(4000);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("You win!");
        winsCount++;
    }
    else if ((computerMove == Rock && playerMove == Scissors) || (computerMove == Paper && playerMove == Rock)
        || computerMove == Scissors && playerMove == Paper)
    {
        await Task.Delay(4000);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("You lose!");
    }
    else
    {
        await Task.Delay(4000);
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("It's a draw!");
    }
    Console.ResetColor();
    counter++;
    Console.WriteLine();
}
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"You won {winsCount} times VS AI.");
Console.ResetColor();