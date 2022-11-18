// Дополнительно. 
// Дан массив. Найдите MEX массива. MEX (Minimum EXcluded) - минимальный отсутствующий элемент.

int[] arrayN = {3, 2, 9, 7, 6};

Console.Write("MEX массива: ");
PrintArray(arrayN);
Console.Write(", является - " + CountMEXNumber(arrayN));

int CountMEXNumber(int[] array)
{
    int[] tempArray = GetSortedArray(array);
    int mexNumber = 1;
    for (int i = 0; i < tempArray.Length; i++)
    {
        if (tempArray[i] == mexNumber)
        {
            mexNumber ++;
        }
        else
        {
            break;
        }
    }
    return mexNumber;
}

int[] GetSortedArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int minIndex = i;
        for (int j = i; j < array.Length; j++)
        {
            if(array[j] < arrayN[minIndex])
            {
                int temp = array[minIndex];
                array[minIndex] = array[j];
                array[j] = temp;
                minIndex = j;
            }
        }
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write(string.Join(", ", array));
}
