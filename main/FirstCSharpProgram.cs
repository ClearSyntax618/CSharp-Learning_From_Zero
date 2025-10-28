using System; // Import the System namespace

int x = 30 + 40;
// System.Console.WriteLine(x);
Console.WriteLine(x); // No need to specify System.

Console.WriteLine(FeetToInches(30)); // Lower-level functions
Console.WriteLine(FeetToInches(40));
SayHello();

int FeetToInches (int feet) { // Higher-level functions
	// Statement block
	int inches = feet * 12;
	return inches;
}

void SayHello() {
	Console.WriteLine("Say 'Hello' to little friend!");
}