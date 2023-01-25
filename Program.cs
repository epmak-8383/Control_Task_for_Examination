string[] array = { "быстро", "дешево", "ура", "качественно", "2" };
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length < 4)
    {
        Console.WriteLine(array[i]);
    }
}