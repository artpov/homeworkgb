Console.Write(" Введите трёхзначное число: ");
int num1 = int.Parse(Console.ReadLine()!);

if ((num1 >= 100) && (num1 < 1000))
{  
    int firstDigigt = num1 % 100;
    int secondDigit = firstDigigt / 10;
    Console.Write(secondDigit);
}
else
{
    Console.Write("Введено не трёхзначное число ");
}
