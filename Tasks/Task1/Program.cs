// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

System.Console.Write("Введите первое число >");
string input1 = Console.ReadLine();
System.Console.Write("Введите второе число >");
string input2 = Console.ReadLine();

int firstNumber = Convert.ToInt32(input1);
int secondNumber = Convert.ToInt32(input2);
if (firstNumber > secondNumber)
{
    Console.WriteLine($"Большее число {firstNumber}");
    Console.WriteLine($"Меньшее число {secondNumber}");
}
else
{
    Console.WriteLine($"Большее число {secondNumber}");
    Console.WriteLine($"Меньшее число {firstNumber}");
}