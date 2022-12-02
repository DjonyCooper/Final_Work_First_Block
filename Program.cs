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
        Console.Write($"> Введите элемент массива под индексом {i}: ");
        array[i] = Console.ReadLine();
    }
    return array;
}  
void ShowArray(string [] array)
{  
    Console.Write("░ Сформирован массив из введенных Вами значений: [");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"\"{array[i]}\"" + "," + " ");
    }
    Console.Write("\b" + "\b \b" + "]");
}
string[] SelectElementMore3Values(string [] array)
{
    int numVal = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if(array[j].Length <= 3)
        {
            numVal++;
        }
    }
    int count = 0;
    string [] newArr = new string [numVal];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            newArr[count] = array[i];
            count++;
        }
    }
    return newArr;
}
void ShowNewArray(string [] array)
{  
    Console.Write("\n░ Из него отобранны значения, которые меньше или равны 3-ем символам и упакованы в новый массив: [");
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"\"{array[i]}\"" + "," + " ");        
        count++;
    }
    if(count > 0) Console.Write("\b" + "\b \b" + "]");
    if(count == 0) Console.Write("]");
}
Console.Write("░ Cколько значений будет содержать Ваш массив?\n> Введите кол-во: "); 
int size = Convert.ToInt32(Console.ReadLine());
if(size <= 0)
{
    Console.Write("Error: К сожалению, невозможно сгенерировать массив с отрицательным размером. Исправьте и повторите попытку!"); 
}
else
{
string [] newArray = CreativeNewArray(size);
ShowArray(newArray);
string [] SelectElement = SelectElementMore3Values(newArray);
ShowNewArray(SelectElement);
}
