// See https://aka.ms/new-console-template for more information
for (int i = 1; i <= 10; i++)
{
    for (int j = 1; j <= i; j++)
        Console.Write("*"); Console.WriteLine();
}
Console.WriteLine("---------------");

for (int i = 1; i <= 10; i++)
{
    for (int j = 1; j <= 10 - i; j++) Console.Write(" ");
    for (int j = 1; j <= i; j++) Console.Write("*"); Console.WriteLine();
}