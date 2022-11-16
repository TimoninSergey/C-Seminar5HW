// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] MassiveHandCreator()
{
    Console.WriteLine("Введите число элементов массива");
    int size = Convert.ToInt16(Console.ReadLine());
    double[] massive = new double[size];

    for (int count = 0; count < massive.Length; count++)
    {
        Console.WriteLine("Введите вещественное число, являющееся элементом массива номер " + count);
        massive[count] = Convert.ToDouble(Console.ReadLine());
    }
    return massive;
}

double MassiveDifFinder(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int count = 0; count < array.Length; count++)
    {
        if (array[count] > max)
        {
            max = array[count];
        }

        else if (array[count] < min)
        {
            min = array[count];
        }
    }
    Console.WriteLine("min " + min);
    Console.WriteLine("max " + max);
    double result = max - min;
    return result;
}

Console.WriteLine(MassiveDifFinder(MassiveHandCreator()));

//