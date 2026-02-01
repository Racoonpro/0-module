var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "AccessChecker API is running");

// Example: /access?age=18
app.MapGet("/access", (int age) =>
{
	bool allowed = age >= 18;

	return Results.Ok(new
	{
		age,
		allowed,
		message = allowed ? "Allowed" : "Not allowed"
	});
});

app.Run();
