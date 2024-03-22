Console.WriteLine("Введите количество элементов в массиве: "); //the user sets the number of items
int number = Convert.ToInt32(Console.ReadLine());
string[] array = new string[number];
for (int i = 0; i < array.Length; i++) //the user enters the elements of the array
{
    Console.WriteLine("Введите элемент массива: ");
    array[i] = Console.ReadLine();
}
Console.WriteLine(" ");
Console.WriteLine("Ваш массив: "); //output of the full array
Console.Write(array[0]);
for (int i = 1; i < array.Length; i++)
{
    Console.Write(", " + array[i]);
}

string[] arrayOfShortElements = new string[array.Length];
int j = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3) //search for the right items
    {
        arrayOfShortElements[j++] = array[i];
    }
    else //in the future: the length of the array with the necessary elements
    {
        number--;
    }
}
Console.WriteLine(" ");
if (number != 0) //output of the required array
{
    Console.WriteLine("Элементы вашего массива, длина которых меньше или равна трем: ");
    Console.Write(arrayOfShortElements[0]);
    for (int i = 1; i < number; i++)
    {
        Console.Write(", " + arrayOfShortElements[i]);
    }
}
else
{
    Console.WriteLine("Ваш массив не содержит элементов, необходимых для выполнения программы.");
}