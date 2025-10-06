int n = 0;
int z = 0;
int zbroj = 0;
Console.WriteLine("unesi broj n :");
n = int.Parse(Console.ReadLine());

do
{
    z++;
    if (z % 2 == 0)
    {
        zbroj += zbroj;
    }
} while (zbroj < n);
Console.WriteLine("ukupan Fibonaccijev zbroj je : {0}", zbroj);
