// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

System.Console.Write("Введите первое число >");
string input1 = Console.ReadLine();
System.Console.Write("Введите второе число >");
string input2 = Console.ReadLine();
System.Console.Write("Введите третье число >");
string input3 = Console.ReadLine();

int firstNumber = Convert.ToInt32(input1);
int secondNumber = Convert.ToInt32(input2);
int thirdNumber = Convert.ToInt32(input3);

int max = firstNumber;
if (firstNumber < secondNumber)
{
    max = secondNumber;
}
if(secondNumber<thirdNumber)
{
    max = thirdNumber;
}
Console.WriteLine($"Максимальное число {max}");