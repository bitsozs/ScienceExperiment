int temp;

do
{
    Console.Write("Enter the temperature in Celsius (must be between -50 and 150): ");
    temp = int.Parse(Console.ReadLine());

    if (temp < -50 || temp > 150)
    {
        Console.WriteLine("Invalid temperature. Please enter a value between -50 and 150.");
    }
}
while (temp < -50 && temp > 150);
Console.WriteLine($"Temperature recorded: {temp} °C");

if (temp < 0)
{
    Console.WriteLine("Category: Freezing");
}
else if (temp >= 0 && temp <= 30)
{
    Console.WriteLine("Category: Normal");
}
else if (temp > 30 && temp <= 100)
{
    Console.WriteLine("Category: Hot");
}
else if (temp > 100 && temp <= 150)
{
    Console.WriteLine("Category: Extremely Hot");
}