/* Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] array = new string[size];

Console.WriteLine("Введите массива");
for (int i = 0; i < array.Length; i++)
{
    array[i] = Console.ReadLine();
}

int number = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
       number++; 
    }
}

Console.WriteLine();
if (number == 0)
{
    Console.Write("Массив не содержит строк меньше или равных трем символам");
}
else
{
    string[] result = new string[number];
    Console.WriteLine("Элементы, содержащие строку меньше или равной трем символам");
    for (int i = 0; i < array.Length; i++)
    {
        number = 0;
        if (array[i].Length <= 3)
        {
            result[number] = array[i];
            Console.WriteLine($"Элемент массива {result[number]}");
            number++;
        }
    }
}