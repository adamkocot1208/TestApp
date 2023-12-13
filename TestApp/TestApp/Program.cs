var numbers = new List<int>();
int number;

Console.WriteLine("Podaj 3 dowolne liczby całkowite: ");

do
{
    Console.WriteLine("Podaj liczbę: ");
    var numberString = Console.ReadLine();
    var success = int.TryParse(numberString, out number );
    if ( success )
    {
        numbers.Add( number );
    }
} while (numbers.Count < 3);

Console.WriteLine("Właśnie wprowadziłeś 3 liczby.");

var maxNumber = numbers.Max();

Console.WriteLine(" ");
Console.WriteLine("Największa liczba spośród podanych to: " + maxNumber.ToString());