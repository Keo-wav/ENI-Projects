// auto indent : CTRL + E + D
long bigOne = long.MaxValue;
Console.WriteLine(bigOne);

// ne fait pas de sens, perte de données à cause de la conversion
int number = ExplicitCast(bigOne);
if (number == bigOne)
    Console.WriteLine(number);

long smallOne = 68456445;
Console.WriteLine(smallOne);

number = ExplicitCast(smallOne);
if (number == smallOne)
    Console.WriteLine(number);


static int ExplicitCast(long number)
{
    int temp = 0;

    if (number > int.MaxValue)
        Console.WriteLine("ça va pas passer chef..");
    else
        temp = (int)number;
    return temp;
}

