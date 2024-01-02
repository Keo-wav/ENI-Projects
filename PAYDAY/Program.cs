    class PayDay
    {
        public static void Main(string[] args)
    {
        // welcome user, prompt for input : last name, first name, position of the employee, number of hours worked, hourly rate & number of kids

        const double Contribution1 = 3.49;
        const double Contribution2 = 6.15;
        const double AssuranceMaladie = 0.95;
        const double AssuranceVieillesse = 8.44;
        const double AssuranceChomage = 3.05;
        const double RetraiteComplementaire = 3.81;
        const double CotisationAGFF = 1.02;

        Console.Write("EMPLOYEE'S FIRST NAME: ");
        string firstName = Console.ReadLine();

        Console.Write("EMPLOYEE'S LAST NAME: ");
        string lastName = Console.ReadLine();

        Console.Write("EMPLOYEE RANK (1-MANAGEMENT, 2-TECHNICIAN, 3-WORKFORCE: ");
        string employeeRankInput = Console.ReadLine();
        int employeeRank = ParseToInt();
        
        Console.Write("EMPLOYEE'S HOURS WORKED: ");
        string hoursWorkedInput = Console.ReadLine();
        int hoursWorked = ParseToInt();

        Console.Write("EMPLOYEE NUMBER OF KIDS: ");
        string numberOfKidsInput = Console.ReadLine();
        int numberOfKids = ParseToInt();

        // Console.WriteLine(firstName);
        // Console.WriteLine(lastName);
        // Console.WriteLine(employeeRank);
        // Console.WriteLine(hoursWorked);
        // Console.WriteLine(numberOfKids);
        
        // Net à payer = salaire de base - Total des cotisations salariales + Prime


    }

    static int ParseToInt()
    {
        string input = Console.ReadLine();
        int output = 0;

        if (input == null || !int.TryParse(input, out output))
            Console.WriteLine("Incorrect input");
        return output;
    }
}
