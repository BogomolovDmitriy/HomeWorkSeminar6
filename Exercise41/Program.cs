// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Введите числа через зарятую: ");
string numbers = Console.ReadLine();

int[] numbersArray = numbers.Split(',').Select(int.Parse).ToArray();
int countNumbers =  CountingPositiveNumbers(numbersArray);
Console.WriteLine($"Пользователем введено {countNumbers} положительных чисел.");


int CountingPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}





