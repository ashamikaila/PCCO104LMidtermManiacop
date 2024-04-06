using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Palamig muna kayo d'yan!");
        Console.WriteLine(); 

        int baseFanPower = 10; 

        int fanSpeed = GetInput("Enter fan speed (1 for low, 2 for medium, 3 for high): ", 1, 3);
        Console.WriteLine(); 

        bool oscillate = GetYesOrNoInput("Oscillate Fan? (Y/N): ");

        int fanPowerOutput = baseFanPower * fanSpeed;

        if (oscillate)
        {
            for (int i = 1; i <= fanPowerOutput; i++)
            {
                Console.WriteLine(new string('~', i));
            }
            for (int i = fanPowerOutput - 1; i > 0; i--)
            {
                Console.WriteLine(new string('~', i));
            }
        }
        else
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(new string('~', fanPowerOutput));
            }
        }
    }

    static int GetInput(string message, int min, int max)
    {
        int input;
        while (true)
        {
            Console.Write(message); 
            if (int.TryParse(Console.ReadLine(), out input) && (input >= min && input <= max))
                return input;
            else
                Console.WriteLine($"Invalid input. Please enter a number between {min} and {max}.");
        }
    }

    static bool GetYesOrNoInput(string message)
    {
        while (true)
        {
            Console.Write(message);
            string input = Console.ReadLine().ToUpper();
            if (input == "Y")
                return true;
            else if (input == "N")
                return false;
            else
                Console.WriteLine("Invalid input. Please enter Y or N.");
        }
    }
}