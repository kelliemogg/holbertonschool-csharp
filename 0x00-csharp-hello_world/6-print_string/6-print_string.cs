using System;

class Program
{
	static void Main(string[] args)
	{
		string str = "Holberton School";
        string nine = str.Substring(0, 9);
		Console.WriteLine($"{str}{str}{str}\n{nine}");
        }
}
