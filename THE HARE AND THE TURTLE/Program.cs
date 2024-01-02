class Program
{
    static void Main()
    {
        int hareWins = 0;

        Console.WriteLine("How many HARE vs TURTLE tests would you like to do ?");
        Console.Write("> ");
        var userInput = Console.ReadLine();

        int numberOfTests;

        if (!int.TryParse(userInput, out numberOfTests))
            Console.WriteLine("WRONG TYPE OF INPUT, PLEASE TYPE AN INTEGER");

        for (int i = 0; i < numberOfTests; i++)
        {
            DetermineWinner();
            if (DetermineWinner() == true) 
            {
                hareWins++;
            }
        }
        Console.WriteLine($"Out of {numberOfTests} tests, the Hare wins {(hareWins*100.0)/ numberOfTests}% of the time");
    }

    static bool DetermineWinner()
    {
        Random random = new Random();
        bool hareVictory = false;

        for (int i = 0; i < 4; i++)
        {
            int rollDice = random.Next(1, 7);
            
            if (rollDice == 6)
                hareVictory = true;
        }

        if (hareVictory)
            return hareVictory;
        else
            return hareVictory = false;
    }
}