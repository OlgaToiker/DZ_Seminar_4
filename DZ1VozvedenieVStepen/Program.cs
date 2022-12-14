//Напишите цикл, который принимает на вход два числа (А и В)
//и возводит число А в натуральную степень В:
// 3, 5 -> 243
// 2, 4 -> 16

Console.Write("Введите число А: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите степень (число В), в которую нужно возвести число А): ");
int b = int.Parse(Console.ReadLine()!);
int result = 1;
for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
Console.WriteLine($"{a}, {b} -> {result}");