// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N

System.Console.WriteLine("Введите число");
string input = Console.ReadLine();
int number = Convert.ToInt32(input);
int count = 1;

while (count <= number)
{
    int remainder = count % 2;
    if (remainder == 0)
    {
        System.Console.Write($"{count} ");
    }
    count++;
}