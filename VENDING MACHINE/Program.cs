using System;

public class VendingMachine
{
    public static void Main(String[] args)
    {

        const double CoffeePrice = 0.60;
        const double MinimumChange = 0.05;
        const int Stock100 = 5;
        const int Stock050 = 7;
        const int Stock020 = 9;
        const int Stock010 = 11;
        const int Stock005 = 12;

        Console.WriteLine("VENDING MACHINE");
        Console.WriteLine("---------------");
        Console.WriteLine($"COFFEE PRICE : {CoffeePrice} EUR");
        Console.WriteLine("---------------");
        Console.WriteLine("ACCEPTED COINS : 2 / 1 / 0,50 / 0,20 / 0,10 / 0,05");

        double insertCoin = 0;

        do
        {
            insertCoin += InsertCoins();

            if (insertCoin > CoffeePrice)
            {
                Console.WriteLine("Here's your coffee and your change");
                CalculateChange(CoffeePrice, insertCoin);
            }
            else if (insertCoin < MinimumChange)
            {
                Console.WriteLine($"Minimum change accepted : {MinimumChange}EUR");
                Console.WriteLine("ACCEPTED COINS : 2 / 1 / 0,50 / 0,20 / 0,10 / 0,05");
            }
            else if (insertCoin < CoffeePrice)
            {
                Console.WriteLine($"Insufficient amount : {insertCoin} EUR / {CoffeePrice} EUR : please add {CoffeePrice - insertCoin} EUR");
            }
            else
                Console.WriteLine("Here's your coffee");
        } while (insertCoin < CoffeePrice);
    }

    static double ParseToDouble()
    {
        string input = Console.ReadLine();
        double output = 0;

        if (input == null || !double.TryParse(input, out output))
            Console.WriteLine("Wrong");
        return output;
    }

    static double InsertCoins()
    {
        Console.Write("INSERT COINS > ");
        double insertCoin = ParseToDouble();
        return insertCoin;
    }

    static void CalculateChange(double CoffeePrice, double insertCoin)
    {
        double changeAmount = insertCoin - CoffeePrice;

        int changeInCents = (int)(changeAmount * 100); // converting change to cents

        int changeOneEuro = changeInCents / 100;
        changeInCents %= 100;

        int change050 = changeInCents / 50;
        changeInCents %= 50;

        int change020 = changeInCents / 20;
        changeInCents %= 20;

        int change010 = changeInCents / 10;
        changeInCents %= 10;

        int change005 = changeInCents / 50;
        changeInCents %= 5;

        if (changeOneEuro != 0)
            Console.WriteLine($"{changeOneEuro} coin of 1 EUR");
        if (change050 != 0)
            Console.WriteLine($"{change050} coin(s) of 0,50 EUR");
        if (change020 != 0)
            Console.WriteLine($"{change020} coin(s) of 0,20 EUR");
        if (change010 != 0)
            Console.WriteLine($"{change010} coin(s) of 0,10 EUR");
        if (change005 != 0)
            Console.WriteLine($"{change005} coin(s) of 0,05 EUR");
    }

    public static bool IsValidCoin(double insertedCoin)
    {
        double[] ValidCoins = { 0.05, 0.10, 0.20, 0.50, 1.00, 2.00 };
        foreach (double coin in ValidCoins)
        {
            if (insertedCoin == coin)
            {
                return true;
            }
        }
        return false;
    }
    
}