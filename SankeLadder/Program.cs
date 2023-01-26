internal class Program
{
    public static void Main(string[] args)
    {
        int start = 0,playerPosition = 0, diceCount=0, TotalDice=0;
        Console.WriteLine("Start Position:" + start);
        while (playerPosition < 100)
        {
            Random random = new Random();
            int roll = random.Next(1, 7);
            Console.WriteLine("\nDice is Rolled: " + roll);
            int Option = random.Next(0, 3);
            if (Option == 0)
            {
                playerPosition = playerPosition - roll;
                if (playerPosition <= 0)
                {
                    playerPosition = 0;
                }
                Console.WriteLine("snake");
                Console.WriteLine("Player Position is: " + playerPosition);
                diceCount++;
            }
            else if (Option == 1)
            {
                playerPosition = playerPosition + roll;
                if (playerPosition > 100)
                {
                    playerPosition = playerPosition - roll;
                }
                Console.WriteLine("ladder");
                Console.WriteLine("Player Position is: " + playerPosition);
                diceCount++;
            }
            else
            {
                Console.WriteLine("no play ");
                Console.WriteLine("Player Position is: " + playerPosition);
                diceCount++;
            }

            if (playerPosition == 100)
            {
                Console.WriteLine("Player is won");
            }
            Console.ReadLine();
        }
        TotalDice += diceCount;
        Console.WriteLine("Total dice count: " + TotalDice);
        Console.ReadLine();
    }
}