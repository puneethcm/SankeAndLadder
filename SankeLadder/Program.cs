internal class Program
{
    public static void Main(string[] args)
    {
        int start = 0,playerPosition1 = 0, diceCount=0, TotalDice=0, playerPosition2 = 0;
        Console.WriteLine("\nWelcome to Sanke And Ladder Game");
        Console.WriteLine("\nPress enter to start the game");
        Console.WriteLine("Start Position:" + start);

        while (playerPosition1 < 100 && playerPosition2 < 100)
        {
            Random random = new Random();
            int player = random.Next(1, 3);
            switch (player)
            {
                case 1:
                    Random random1 = new Random();
                    int roll = random1.Next(1, 7);
                    Console.WriteLine("\nDice is Rolled: " + roll);
                    int Option = random1.Next(1, 2);
                    if (Option == 0)
                    {
                        playerPosition1 = playerPosition1 - roll;
                        if (playerPosition1 <= 0)
                        {
                            playerPosition1 = 0;
                        }
                        Console.WriteLine("snake");
                        Console.WriteLine("Player1 Position is: " + playerPosition1);
                        diceCount++;
                    }
                    else if (Option == 1)
                    {
                        playerPosition1 = playerPosition1 + roll;
                        if (playerPosition1 > 100)
                        {
                            playerPosition1 = playerPosition1 - roll;
                        }
                        Console.WriteLine("ladder");
                        Console.WriteLine("Player1 Position is: " + playerPosition1);
                        diceCount++;
                    }
                    else
                    {
                        Console.WriteLine("no play ");
                        Console.WriteLine("Player1 Position is: " + playerPosition1);
                        diceCount++;
                    }

                    if (playerPosition1 == 100)
                    {
                        Console.WriteLine("Player1 is won");
                    }
                    Console.ReadLine();
                    break;

                case 2:
                    Random random2 = new Random();
                    int roll2 = random2.Next(1, 7);
                    Console.WriteLine("\nDice is Rolled: " + roll2);
                    int Option2 = random2.Next(1, 2);
                    if (Option2 == 0)
                    {
                        playerPosition2 = playerPosition2 - roll2;
                        if (playerPosition2 <= 0)
                        {
                            playerPosition2 = 0;
                        }
                        Console.WriteLine("snake");
                        Console.WriteLine("Player2 Position is: " + playerPosition2);
                        diceCount++;
                    }
                    else if (Option2 == 1)
                    {
                        playerPosition2 = playerPosition2 + roll2;
                        if (playerPosition2 > 100)
                        {
                            playerPosition2 = playerPosition2 - roll2;
                        }
                        Console.WriteLine("ladder");
                        Console.WriteLine("Player2 Position is: " + playerPosition2);
                        diceCount++;
                    }
                    else
                    {
                        Console.WriteLine("no play ");
                        Console.WriteLine("Player2 Position is: " + playerPosition2);
                        diceCount++;
                    }

                    if (playerPosition2 == 100)
                    {
                        Console.WriteLine("Player2 is won");
                    }
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Plaese roll dice agiain");
                    break;
            }
        }
        TotalDice += diceCount;
        Console.WriteLine("Total dice count: " + TotalDice);
        Console.ReadLine();
    }
}