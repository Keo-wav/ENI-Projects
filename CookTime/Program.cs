public class TempsCuisson
{

    public static void Main(String[] args)
    {

        int choixViande;
        int choixCuisson;
        double poidsViande;
        double tempsCuissonInitial = 0;

        const double ConstanteCuissonBoeufBleu = 6.0 / 5.0;
        const double ConstanteCuissonBoeufAPoint = 1020.0 / 500.0;
        const double ConstanteCuissonBoeufBienCuit = 15.0 / 5.0;

        const double ConstanteCuissonAgneauBleu = 9.0 / 4.0;
        const double ConstanteCuissonAgneauAPoint = 1500.0 / 400.0;
        const double ConstanteCuissonAgneauBienCuit = 24.0 / 4.0;

        Console.WriteLine("Quelle est la viande que vous voulez cuire ?");
        Console.WriteLine("1 - Boeuf, 2 - Agneau");
        choixViande = ParseToInt();

        Console.WriteLine("Quelle est la cuisson souhaitée ?");
        Console.WriteLine("1 - Saignant, 2 - À point, 3 - Bien cuit");
        choixCuisson = ParseToInt();

        Console.WriteLine("Combien pèse votre pièce ? (en grammes)");
        poidsViande = ParseToInt();

        string messageFinal = "Vous devez cuire pendant ";

        switch (choixCuisson)
        {
            case 1:
                if (choixViande == 1)
                    tempsCuissonInitial = ConstanteCuissonBoeufBleu * poidsViande;
                else
                    tempsCuissonInitial = ConstanteCuissonAgneauBleu * poidsViande;
                break;
            case 2:
                if (choixViande == 1)
                    tempsCuissonInitial = ConstanteCuissonBoeufAPoint * poidsViande;
                else
                {
                    Console.WriteLine(ConstanteCuissonAgneauAPoint);
                    Console.WriteLine(poidsViande);

                    tempsCuissonInitial = ConstanteCuissonAgneauAPoint * poidsViande;
                    Console.WriteLine(tempsCuissonInitial);
                }
                break;

            case 3:
                if (choixViande == 1)
                    tempsCuissonInitial = ConstanteCuissonBoeufBienCuit * poidsViande;
                else
                    tempsCuissonInitial = ConstanteCuissonAgneauBienCuit * poidsViande;
                break;
        }

        int tempsCuissonFinal = (int)Math.Ceiling(tempsCuissonInitial);
        messageFinal += tempsCuissonFinal;
        messageFinal += " secondes.";
        Console.WriteLine(messageFinal);

        static int ParseToInt()
        {
            string input = Console.ReadLine();
            int output = 0;

            if (input == null || !int.TryParse(input, out output))
                Console.WriteLine("dommage");
            return output;
        }
    }

}
