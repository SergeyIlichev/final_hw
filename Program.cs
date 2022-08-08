/*
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

Console.WriteLine("Введите количество элементов массива: ");
int numberOfElements = int.Parse(Console.ReadLine());
string[] array = new string[numberOfElements];
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите элемент массива c индексом {i}: ");
    array[i] = Console.ReadLine();
}
Console.WriteLine("Получившийся массив: ");
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine(string.Empty);
Console.WriteLine("Массив с элементами, длина которых меньше, либо равна 3 символам: ");
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
        Console.Write(array[i] + " ");
}