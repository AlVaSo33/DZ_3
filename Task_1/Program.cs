// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
//14212 -> нет
//12821 -> да
//23432 -> да

int GetNumberPalindrome(int number)
{
    int firstMeaning = number;
    int secondMeaning = 0;
    while (number > 0)
    {
        int number2 = number % 10;
        secondMeaning = secondMeaning * 10 + number2;
        number = number / 10;

    }

    if (secondMeaning == firstMeaning)
        Console.WriteLine("Число является палиндромом");
    else
        Console.WriteLine("Число не является палиндромом");

    return (number);
}

Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine()!);

int Meaning = GetNumberPalindrome(number);


