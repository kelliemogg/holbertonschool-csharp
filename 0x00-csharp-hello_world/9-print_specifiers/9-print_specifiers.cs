using System;

class Program
{
	static void Main(string[] args)
	{
		double percent = .7553;
		double currency = 98765.4321;
		Console.WriteLine($"Percent: {percent,1:P}\nCurrency: {currency,0:C}");
	}
}
