void FillArray(string[] str)
{
    for (int i = 0; i < str.Length; i++)
    {
        Console.Write((i + 1) + " строка: ");
        str[i] = Console.ReadLine();
    }
}

string[] CreateNewArray(string[] str)
{
    string[] noElementsInArray = {"нет подходящих строк в веденном массиве"};
    int sizeOfTheNewArray = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].Length <= 3)
            sizeOfTheNewArray++;
    }
    if (sizeOfTheNewArray != 0)
    {
        string[] newWords = new string[sizeOfTheNewArray];
        int count = 0;
        for (int j = 0; j < str.Length; j++)
        {
            if (str[j].Length <= 3)
            {
                newWords[count] = str[j];
                count++;
            }
        }
        return newWords;
    }
    else return noElementsInArray;
}

Console.Write("Количество строк в массиве: ");
int size = int.Parse(Console.ReadLine());
string[] words = new string[size];

Console.WriteLine("Введите массив: ");
FillArray(words);
Console.WriteLine("Введенный массив: " + string.Join(", ", words));

CreateNewArray(words);

Console.WriteLine("Полученный массив: " + string.Join(", ", CreateNewArray(words)));