//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("A=");
int numA = int.Parse(Console.ReadLine()!);
Console.WriteLine("B=");
int numB = int.Parse(Console.ReadLine()!);

int expfunction = power(numA, numB);
Console.WriteLine(expfunction);

int power(int numberA, int numberB)
{
    int expAinB = numberA;
    for (int i = 1; i<numberB;i++)
{
    expAinB = expAinB * numberA;
}
return expAinB;
}