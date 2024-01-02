internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("ASCII ART 101 : CARD CASTLE BUILDER");
        Console.WriteLine("ENTER THE NUMBER OF STORIES FOR THE CASTLE : ");
        Console.Write("> ");
        var userInput = Console.ReadLine();

        int nbFloors;

        if (!int.TryParse(userInput, out nbFloors))
            Console.WriteLine("WRONG TYPE OF INPUT, PLEASE TYPE AN INTEGER");
        else
            BuildCastleUpwards(nbFloors);
            BuildCastleDownwards(nbFloors);

        Console.ReadLine();
    }

    static void BuildCastleUpwards(int number)
    {
        for (int i = 0; i < number; i++)
        {
            // Add spaces to achieve symmetry on both sides
            string spaces = new string(' ', number - i);
            string cardBlock = "/\\";
            // Adjust the castle line print to achieve symmetry
            Console.WriteLine(spaces + BuildCastleLine(i) + cardBlock + spaces);
        }
    }
        static void BuildCastleDownwards(int number)
    {
        for (int i = number; i >= 0; i--)
        {
            // Add spaces to achieve symmetry on both sides
            string spaces = new string(' ', number - i);
            string cardBlock = "\\/";
            // Adjust the castle line print to achieve symmetry
            Console.WriteLine(spaces + BuildCastleLine(i) + cardBlock + spaces);
        }
    }

    static string BuildCastleLine(int number)
    {
        string cardBlock = "/\\";
        string blockLine = "";
        // Adjust the loop to create block lines with appropriate length
        for (int i = 0; i < number; i++)
        {
            blockLine += cardBlock;
        }
        return blockLine;
    }
}