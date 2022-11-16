// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] MassiveCreator()
{
    Console.WriteLine("Введите число элементов массива");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] massive = new int[size];

    for (int count = 0; count < massive.Length; count++)
    {
        massive[count] = new Random().Next(100, 1000);
        Console.WriteLine(massive[count]);
    }
    return massive;
}

int MassiveEvenCounter(int[] array)
{
    int answer = 0;
    for (int count = 0; count < array.Length; count++)
    {
        if (array[count] % 2 == 0)
        {
            answer++;
        }
    }
    return answer;
}

Console.WriteLine(MassiveEvenCounter(MassiveCreator()));

//Программа выводит сами элементы массива, помимо количества четных чисел, для удобства проверки.


