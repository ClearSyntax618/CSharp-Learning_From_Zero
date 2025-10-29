using System; // Import the System namespace

public struct ValueType
{
	public int X;
	public int Y;
}

public class Pointer
{
	public int X;
	public int Y;
}

class Program
{
	static void Main(string[] args)
	{

		void ValueType()
		{
			// -------- VALUE TYPES ----------
			ValueType p1 = new ValueType();
			p1.X = 7;

			// A value type cannot have a null value

			ValueType p2 = p1; // Assignment causes copy
			
			Console.WriteLine("\nValue Types");
			Console.WriteLine(p1.X); // 7
			Console.WriteLine(p2.X); // 7

			p1.X = 9;
			Console.WriteLine(p1.X); // 9
			Console.WriteLine(p2.X + "\n"); // 7
		}

		void Pointers()
		{
            
			Pointer p1 = new Pointer();
			p1.X = 8;

			Pointer p2 = p1; // Copies p1 reference

			Console.WriteLine("\nPunteros");
			Console.WriteLine(p1.X); // 8
			Console.WriteLine(p2.X); // 8

			p1.X = 10;

			Console.WriteLine(p1.X); // 10
			Console.WriteLine(p2.X + "\n"); // 10
        }



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
		ValueType();
		Pointers();

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


