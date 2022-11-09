// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine()!);

int[] GetSqrtCubeTable(int number)
{
    int[] SqrtArray = new int[number];

    for (int i = 0; i < number; i++)
    {
        SqrtArray[i] = (i + 1) * (i + 1) * (i + 1);
    }

    return SqrtArray;
}
void PrintTable(int[] Array)
{
    int number = 1;
    for (int i = 0; i < Array.Length; i++)
    {
        Console.WriteLine($"{number}^3 = {Array[i]}");
        number++;
    }
}

int[] SqrtTable = GetSqrtCubeTable(number);
PrintTable(SqrtTable);

