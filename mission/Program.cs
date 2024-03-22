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
