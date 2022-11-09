// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
double distance(int[] dotsA, int[] dotsB)
{
    return Math.Sqrt(Math.Pow(dotsA[0] - dotsB[0], 2) + Math.Pow(dotsA[1] - dotsB[1], 2) + Math.Pow(dotsA[2] - dotsB[2], 2));
}
int[] dotsA = new int[3];
int[] dotsB = new int[3];

Console.WriteLine("Введите координату X(A):");
dotsA[0] = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату Y(A):");
dotsA[1] = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату Z(A):");
dotsA[2] = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату X(B):");
dotsB[0] = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату Y(B):");
dotsB[1] = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату Z(B):");
dotsB[2] = int.Parse(Console.ReadLine()!);

Console.WriteLine("Расстояние между точками");
Console.WriteLine(Math.Round(distance(dotsA, dotsB), 2));