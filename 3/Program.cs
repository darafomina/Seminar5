// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

// [3 7 22 2 78] -> 76

int[] createArray()
{   
    Console.Write("Введите колличество элементов массива:\t");
    int elementsCount = int.Parse(Console.ReadLine());

    int[] array = new int[elementsCount];
    var random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100, 1000);
    }

    return array;
}
    int searcMAXhNumber(int[] arr)
{
    int max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    return max;
}
int searcMINhNumber(int[] arr)
{
    int min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    return min;
}

void viewArr(int[] arr)
{
    string result = "[";
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
        {
            result += arr[i] + ", ";
        }
        if (i == arr.Length - 1)
        {
            result += arr[i] + "]";
        }
    }
    Console.WriteLine(result);
}

int[] array = createArray();
viewArr(array);

Console.WriteLine("Максимальный элемент массива\n" + searcMAXhNumber(array));
Console.WriteLine("Минимальный элемент массива\n" + searcMINhNumber(array));
int result = searcMAXhNumber(array) -searcMINhNumber(array);
Console.WriteLine("Разница между максимальным и минимальным элементами массива\n" + result);