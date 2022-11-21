// Работа с текстом
// Дан текст. Надо заменить в тексте все пробелы черточками, маленькие буквы "к  большими "К", 
// а большие "С" маленькми "с".

Console.Clear();

string text = "- Я думаю, - сказал князь, улыбнись, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";


string Replace (string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|');
newText = Replace(newText, 'к', 'К');
newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);
