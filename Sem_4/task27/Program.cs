//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()!);

int digitFunction = Sumdigit(num);
Console.WriteLine(digitFunction);

int Sumdigit(int number)
{
    int sum = 0;
    while (number>=10)
    {
        sum += number %10;
        number /= 10;
    }
    return sum + number;
}