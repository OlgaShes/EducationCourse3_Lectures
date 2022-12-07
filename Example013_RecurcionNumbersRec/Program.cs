// Собрать строку с числами от a до b

string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i < b + 1; i++)
    {
        result += $"{i} ";
    }
    return result;
}

// string NumbersRec(int a, int b)
// {
//     if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
//     else return string.Empty;
// }

string NumbersRec(int a, int b)
{
    if (a < b) return $"{a} " + NumbersRec(a + 1, b);
    else return $"{a} ";
}


// Собрать строку с числами от b до a

string Numbers2For(int a, int b)
{
    string result = String.Empty;
    for (int i = b; i > a - 1; i--)   // Понадобилось переписать условие
    {
        result += $"{i} ";
    }
    return result;
}

string Numbers2Rec(int a, int b)
{
    if (a <= b) return Numbers2Rec(a + 1, b) + $"{a} ";  // Поменяли только порядок вывода чисел
    else return string.Empty;
}

Console.WriteLine(NumbersFor(1, 11));
Console.WriteLine(NumbersRec(1, 11));
Console.WriteLine(Numbers2For(1, 11));
Console.WriteLine(Numbers2Rec(1, 11));
