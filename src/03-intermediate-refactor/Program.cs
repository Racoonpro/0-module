Console.WriteLine("=== Access Checker ===");

Console.Write("Enter your name: ");
string? name = Console.ReadLine();

if (string.IsNullOrWhiteSpace(name))
{
	Console.WriteLine("Name is required. Please restart and enter a name.");
	return;
}

Console.Write("Enter your age: ");
string? ageText = Console.ReadLine();

if (!int.TryParse(ageText, out int age))
{
	Console.WriteLine("That doesn't look like a number. Please restart and enter a whole number (e.g., 18).");
	return;
}

if (!IsAgeRealistic(age))
{
	Console.WriteLine("That age doesn't look valid. Please restart and enter a realistic age (0–120).");
	return;
}

bool isAllowed = IsAllowed(age);

Console.WriteLine();
Console.WriteLine($"Name: {name}");
Console.WriteLine($"Age: {age}");
Console.WriteLine(isAllowed ? "Result: ✅ Allowed" : "Result: ❌ Not allowed");

static bool IsAllowed(int age) => age >= 18;

static bool IsAgeRealistic(int age) => age >= 0 && age <= 120;
