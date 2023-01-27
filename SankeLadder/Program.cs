internal class Program
{
    public static void Main(string[] args)
    {
        int start = 0, playerPosition = 0, diceCount=0, totalDiceCount=0;
        const int SNAKE = 0, LADDER = 1;
        Console.WriteLine("Start Position:" + start);
        while (playerPosition < 100)
        {
            Random random = new Random();
            int roll = random.Next(1, 7);
            Console.WriteLine("\nDice is Rolled: " + roll);
            int Option = random.Next(0, 3);
            diceCount++;
            switch (Option)
            {
                case SNAKE:
                    playerPosition -= roll;
                    Console.WriteLine("Snake");
                    if (playerPosition <= 0)
                    {
                        playerPosition = 0;
                        Console.WriteLine("Player position is: " + playerPosition);
                    }
                    else
                    {
                        Console.WriteLine("Player position is: " + playerPosition);
                    }
                    break;
                case LADDER:
                    playerPosition += roll;
                    Console.WriteLine("Ladder");
                    if (playerPosition == 100)
                    {
                        Console.WriteLine("Player is Won");
                    }
                    else if (playerPosition > 100)
                    {
                        playerPosition = playerPosition - roll;
                        Console.WriteLine("Player remains in same position: " + playerPosition);
                    }
                    else
                    {
                        Console.WriteLine("Player position id : " + playerPosition);
                    }
                    break;

                default:
                    //playerPosition += roll;
                    Console.WriteLine("No game");
                    Console.WriteLine("Player position is: " + playerPosition);
                    break;
            }
        }
        totalDiceCount += diceCount;
        Console.WriteLine("Total Dice Count played to win the game: " + totalDiceCount);
        Console.ReadLine();
    }
}