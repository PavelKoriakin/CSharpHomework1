// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка)

System.Console.Write("Введите число >");
string input = Console.ReadLine();
int number = Convert.ToInt32(input);
int remainder = number % 2;
if (remainder > 0)
{
    System.Console.WriteLine($"Число {number} является не четным");
}
else
{
    System.Console.WriteLine($"Число {number} является четным");
}