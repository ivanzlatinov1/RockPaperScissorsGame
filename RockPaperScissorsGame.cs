string Rock = "Rock";
string Paper = "Paper";
string Scissors = "Scissors";

Console.Write("Choose [r]ock, [p]aper or [s]cissors: ");

//Adding playerMove + logic

string playerMove = Console.ReadLine();
switch (playerMove)
{
    case "r":
    case "rock":
    case "Rock":
        playerMove = Rock;
        break;

    case "p":
    case "paper":
    case "Paper":
        playerMove = Paper;
        break;

    case "s":
    case "scissors":
    case "Scissors":
        playerMove = Scissors;
        break;

    default:
        Console.WriteLine("Invalid input. Try Again...");
        break;
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
Console.WriteLine($"The computer chose {computerMove}.");

//Implementing win/draw/lose logic

await Task.Delay(1000);
Console.WriteLine("Calculating result...");

if ((playerMove == Rock && computerMove == Scissors) || (playerMove == Paper && computerMove == Rock)
    || playerMove == Scissors && computerMove == Paper)
{
    await Task.Delay(4000);
    Console.WriteLine("You win!");
}
else if ((computerMove == Rock && playerMove == Scissors) || (computerMove == Paper && playerMove == Rock)
    || computerMove == Scissors && playerMove == Paper)
{
    await Task.Delay(4000);
    Console.WriteLine("You lose!");
}
else
{
    await Task.Delay(4000);
    Console.WriteLine("It's a draw!");
}