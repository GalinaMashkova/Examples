﻿// Задача.
//Дан текст. В тексте нужно все пробелы заменить черточками, маленькие буквы "к" заменить
// большими "К", а большие "С" заменить маленькими"с".
string text = "Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чай?";

// string s = "qwerty
//             012 
// s [3] // r

string Replace(string text, char oldValue, char newValue)
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

String newText = Replace(text, ' ', '|');
Console.WriteLine(newText);

Console.WriteLine(); // пробел
newText = Replace(text, 'к', 'К');
Console.WriteLine(newText);

Console.WriteLine(); // пробел
newText = Replace(text, 'C', 'C');
Console.WriteLine(newText);