using System;

Console.Write("Введите число");
string? number = Console.ReadLine();

void CheckingNumber(string number){
    if (number [0] == number [4] || number [1] == number [3]){
        Console.WriteLine($"Ваше число: {number} - да");
    }
    else Console.WriteLine($"Ваше число: {number} - нет");
}

if (number!.Length == 5){
    CheckingNumber(number);
}
else Console.WriteLine("Введите правильное число");