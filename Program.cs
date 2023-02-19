string[] array = {"new", "1819", "stpr", "192", "dog", "1254", "progect", "M12"};

string[] ShortArray(string[] array)
{
    string[] shortArray = new string[array.Length];
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            shortArray[count] = array[i];
            count++;
        }
    }
    return shortArray;
}

void ShowArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

ShowArray(ShortArray(array));