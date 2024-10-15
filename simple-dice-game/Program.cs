
Console.WriteLine("Welcome to the Dice Game!");

Random random = new Random();


int playerRandNum;
int enemyRandNum;

int playerPts = 0;
int enemyPts = 0;

int rounds = random.Next(1, 6);

Console.WriteLine($"This game has {rounds} rounds!");

for (int i = 0; i < rounds; i++)
{
    Console.WriteLine($"---------------------Round {i+1}---------------------");
    Console.WriteLine("Press any key to roll the dice.");

    Console.ReadKey();
    Console.WriteLine();

    playerRandNum = random.Next(1, 7);
    Console.WriteLine("You rolled a " + playerRandNum);

    Console.WriteLine("...");
    Thread.Sleep(1000);

    enemyRandNum = random.Next(1, 7);
    Console.WriteLine("Enemy rolled a " + enemyRandNum);

    if (playerRandNum > enemyRandNum)
    {
        Console.WriteLine("...");
        Thread.Sleep(1000);
        Console.WriteLine("You win this round!");
        playerPts++;
    }
    else if (enemyRandNum > playerRandNum)
    {
        Console.WriteLine("...");
        Thread.Sleep(1000);
        Console.WriteLine("Enemy wins this round :(");
        enemyPts++;
    }
    else
    {
        Console.WriteLine("...");
        Thread.Sleep(1000);
        Console.WriteLine("Draw!");
    }
    Console.WriteLine();
    Console.WriteLine("Your points: " + playerPts + " Enemy points: " + enemyPts);
    Console.WriteLine();
}

Console.WriteLine("---------------------Results---------------------");

if (playerPts > enemyPts)
{
    Console.WriteLine("You won the match!");
}
else if (enemyPts > playerPts)
{
    enemyPts++;
    Console.WriteLine("Enemy won the match :(");
}
else
{
    Console.WriteLine("This match was a draw :|");
}

