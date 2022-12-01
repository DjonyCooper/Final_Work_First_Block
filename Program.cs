// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
// меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на 
// старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []
string [] CreativeNewArray(int size)
{
    string [] array = new string[size];
    Console.Write("\n");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}: ");
        array[i] = Console.ReadLine();
    }
    return array;
}  
void ShowArroy(string [] array)
{   
    Console.Write($"Вы ввели следующие значения: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "," + " ");
    }
    Console.Write("\b" + "\b \b");
}
void SelectElementMore3Values(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            Console.Write("");
        }
    }
}
Console.Write("Cколько значений будет содержать Ваш массив?\n> Введите кол-во: "); 
int size = Convert.ToInt32(Console.ReadLine());
if(size <= 0)
{
    Console.Write("К сожалению, невозможно сгенерировать массив с отрицательным размером. Исправьте и повторите попытку!"); 
}
else
{
string [] newArray = CreativeNewArray(size);
ShowArroy(newArray);
}