Console.WriteLine("=== Access Checker ===");

Console.Write("Enter your name: ");
string? name = Console.ReadLine();

Console.Write("Enter your age: ");
string? ageText = Console.ReadLine();
int age = int.Parse(ageText!);

if (age >= 18)
{
	Console.WriteLine($"{name}: Allowed");
}
else
{
	Console.WriteLine($"{name}: Not allowed");
}
