internal class Program
{
    public static void Main(string[] args)
    {
        int start = 0, playerPosition=0;
        Console.WriteLine("\nStart Position:" + start);

        Random random = new Random();
        int roll = random.Next(0, 7);
        playerPosition = roll;
        Console.WriteLine("\nDice rolled number is: " + roll);
        Console.WriteLine("\nPlayer position is: " + playerPosition);
        Console.ReadLine();
    }
}