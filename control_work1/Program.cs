void FillArray(string[] str)
{
    for (int i = 0; i < str.Length; i++)
    {
        Console.Write((i + 1) + " строка: ");
        str[i] = Console.ReadLine();
    }
}

Console.Write("Сколько нужно строк в массиве: ");
int size = int.Parse(Console.ReadLine());
string[] words = new string[size];

Console.WriteLine("Введите массив: ");
FillArray(words);
Console.WriteLine(string.Join(", ", words));