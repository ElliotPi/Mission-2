using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.WriteLine("How many dice rolls would you like to simulate?");
        int NumOfRolls = int.Parse(Console.ReadLine());

        RollDice.RollDice rs = new();

        int[] results = rs.RollingSimulator(NumOfRolls);

        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine($"Total number of rolls = {NumOfRolls}.\n");

        for (int i = 0; i < results.Length; i++)
        {
            int percentage = (results[i] * 100 / NumOfRolls);
            string totalAsterisks = "";
            for (int count = 0; count <= percentage; count++)
            {
                totalAsterisks += "*";
            }
            Console.WriteLine($"{i + 2}: {totalAsterisks}");

        }


    }
}

