var possibleDividers = new List<int>();
var dividers = new List<int>();
var primeNumbers = new List<int>();

Console.WriteLine("Podaj liczbę całkowitą większą niż 1: ");
var numberString = Console.ReadLine();
var success = int.TryParse(numberString, out int number);

if (success && number > 1)
{
    for (int num = 2; num <= number; num++)
    {
        var numSqrt = Math.Sqrt(num);
        for (int j = 1; j <= numSqrt; j++)
        {
            possibleDividers.Add(j);
        }

        foreach (var i in possibleDividers)
        {
            if (num % i == 0)
            {
                dividers.Add(i);
            }
        }

        if (dividers.Count == 1)
        {
            primeNumbers.Add(num);
        }

        possibleDividers.Clear();
        dividers.Clear();
    }

    Console.WriteLine(" ");
    Console.WriteLine("Liczby pierwsze mniejsze lub równe " + number + " to:");
    foreach (int i in primeNumbers)
    {
        Console.WriteLine(i);
    }
}
else
{
    Console.WriteLine("Podano błędną liczbę");
}