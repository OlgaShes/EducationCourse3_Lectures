void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];
FillArray(array);
Console.WriteLine("Сформированный массив:");
PrintArray(array);
Console.WriteLine();
Console.Write("Введите искомый элемент: ");
int elementNumber = Convert.ToInt32(Console.ReadLine());
int pos = IndexOf(array, elementNumber);
if (pos < 0) Console.WriteLine("Элемент не найден");
else Console.WriteLine($"Данный элемент впервые встречается на позиции {pos}");