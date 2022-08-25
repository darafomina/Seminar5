// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


int[] createArray()
{   
    Console.Write("Введите колличество элементов массива:\t");
    int elementsCount = int.Parse(Console.ReadLine());

    int[] array = new int[elementsCount];
    var random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(1, 100);
    }

    return array;
}
    int searcNumbers(int[] arr)
{
    int result = 0;
    for (int i = 1; i < arr.Length; i = i+2)
    {

         result +=arr[i];
    }
    return result;
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

Console.WriteLine("Сумма элементов, стоящих на нечётных позициях\n" + searcNumbers(array));
