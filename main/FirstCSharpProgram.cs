using System; // Import the System namespace

class Program
{
	static void Main(string[] args)
	{

		int x = 30 + 40;
		string message = "Hola Mundo";
		int year = 2025;
		string messageWithYear = message + " " + year.ToString();

		// System.Console.WriteLine(x);
		Console.WriteLine(x); // No need to specify System.
		Console.WriteLine(message);
		Console.WriteLine(messageWithYear);

		Console.WriteLine(FeetToInches(30)); // Lower-level functions
		Console.WriteLine(FeetToInches(40));
		SayHello();

		/// ---------------------------------------
		/// Built-in types
		/// ---------------------------------------
		bool exists = false;
		if (exists)
			Console.WriteLine("El valor existe");

		int y = 5000;
		bool lessThanFiveThousand = y < 5280;
		if (lessThanFiveThousand)
			Console.WriteLine("El valor de y es: " + y);

		int FeetToInches(int feet)
		{ // Higher-level functions
		  // Statement block
			int inches = feet * 12;
			return inches;
		}

		void SayHello()
		{
			Console.WriteLine("Say 'Hello' to little friend!");
		}

		/// -------------------------------------
		/// Custom Types
		/// -------------------------------------
		UnitConverter feetToInches = new UnitConverter(12);
		Console.WriteLine(feetToInches.Convert(30));
	}
}

public class UnitConverter
{
	int ratio; // Fields

	public UnitConverter(int unitRatio) // Constructor
	{
		ratio = unitRatio;
	}

	public int Convert(int unit) // Method
	{
		return unit * ratio;
	}

}


