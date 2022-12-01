// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
// меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на 
// старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []
int [] CreativeNewArray(int size)
{
    int [] array = new int[size];
    Console.Write("\n");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}: ");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}  
void ShowArroy(int [] array)
{   
    Console.Write($"Вы ввели следующие числа: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ",");
    }
    Console.Write("\b \b");
}
int SelectElementMore3Values(int [] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            sum++;
        }
    }
    return sum;
}
Console.Write("Cколько значений будет содержать Ваш массив?\n> Введите кол-во: "); 
int size = Convert.ToInt32(Console.ReadLine());
if(size <= 0)
{
    Console.Write("К сожалению, невозможно сгенерировать массив с отрицательным размером. Исправьте и повторите попытку!"); 
}
else
{
int [] newArray = CreativeNewArray(size);
ShowArroy(newArray);
if(SelectElementMore3Values(newArray) == 0)
{
    Console.Write($"\nВ массиве нет значений меньше или равных 3-ем символам");
}
else
{
    Console.Write($"\nСреди них {SelectElementMore3Values(newArray)}, больше 3-ех символов");
}
}