// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [’’hello", "2", "world", -> ["2", ":-)’’]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

string[] CreateArray()
{
    Console.Write("How much elements should be in the array? \nEnter: ");
    int a = Convert.ToInt32(Console.ReadLine());
    string[] arr = new string[a];
    return arr;
}

string[] FillArray(string[] arr)
{
    System.Console.WriteLine("Enter array elements separated by semicolon (';'), and don't use spaces. \nEnter: ");
    arr = Console.ReadLine().Split(";").ToArray();
    return arr;
}

void PrintArray(string[] arr)
{
    System.Console.Write("[ ");
    Console.Write(string.Join(" ; ", arr));
    System.Console.Write(" ]");
}

string[] SelectArrayElements(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length >= 0 && arr[i].Length <= 3)
        {
            count++;
        }
    }

    string[] newarr = new string[count];
    count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length >= 0 && arr[i].Length <= 3)
        {
            newarr[count] = arr[i];
            count++;
        }
    }
    return newarr;
}







string[] myarray = CreateArray();
System.Console.WriteLine();

myarray = FillArray(myarray);

System.Console.WriteLine();
System.Console.WriteLine("Received array:");
PrintArray(myarray);
System.Console.WriteLine();

string[] newmyarray = SelectArrayElements(myarray);

System.Console.WriteLine();
System.Console.WriteLine("New array:");
PrintArray(newmyarray);
System.Console.WriteLine();