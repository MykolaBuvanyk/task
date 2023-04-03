using System;

class Program
{
    static void Main()
    {
        // Встановлення діапазону значень
        const int minVal = 15;
        const int maxVal = 85;

        // Створення генератора випадкових чисел
        Random rand = new Random();

        // Створення масиву з 21 елементом
        int[] array = new int[21];

        // Заповнення масиву випадковими числами
        FillArray(array, rand, minVal, maxVal);

        // Виведення масиву на екран
        Console.WriteLine("Початковий масив:");
        PrintArray(array);

        // Сортування масиву за зростанням
        Array.Sort(array);

        // Обчислення кількості та суми елементів, що задовольняють критерію
        int count = 0;
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 != 0 && i % 13 != 0)
            {
                count++;
                sum += array[i];
                array[i] = 0;
            }
        }

        // Виведення кількості та суми на екран
        Console.WriteLine("Count elements: " + count);
        Console.WriteLine("Сума елементiв, що задовольняють критерiю: " + sum);

        // Виведення модифікованого масиву на екран
        Console.WriteLine("Модифiкований масив:");
        PrintArray(array);
    }

    // Метод для заповнення масиву випадковими числами
    static void FillArray(int[] array, Random rand, int minVal, int maxVal)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(minVal, maxVal + 1);
        }
    }

    // Метод для виведення масиву на екран
    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0,3}", array[i]);
        }

        Console.WriteLine();
    }
}
