// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] MassiveCreator()
{
    Console.WriteLine("Введите число элементов массива");
    int size = Convert.ToInt16(Console.ReadLine());
    int[] massive = new int[size];

    for (int count = 0; count < massive.Length; count++)
    {
        massive[count] = new Random().Next(-10, 10);
        Console.WriteLine(massive[count]);
    }
    return massive;
}

int MassiveUnevenSummer(int[] array)
{
    int sum = 0;
    for (int count = 0; count < array.Length; count = count + 2)
    {
        sum = sum + array[count];
    }
    return sum;
}

Console.WriteLine(MassiveUnevenSummer(MassiveCreator()));

// Программа выводит значения элементов массива для удобства проверки. 
// Также значения элементов массива были ограничены интервалом (-10; 10) для удобства проверки. 