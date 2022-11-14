int[] array = { 21, 32, 83, 14, 21, 62, 72, 18 };
int n = array.Length;
int find = 21;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;

}