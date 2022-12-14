// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19-> [1, 2, 5, 7, 19]
//6, 1, 33-> [6, 1, 33]

int Number = 8;
int[] array = new int[Number];

for (int i = 0; i < Number; i++)
{
    array[i] = new Random().Next(Number + 1);
    Console.Write(array[i] + ", ");
}
Console.Write("->");
Console.WriteLine($"[{String.Join(", ", array)}]");