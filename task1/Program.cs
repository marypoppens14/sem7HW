//задача 47. Двумерный массив размером m*n, заполненный случайными вещественными числами
//задача 50. на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет
//задача 52. двумерный массив из целых чисел. Найти среднее арифметическое элементов в каждом столбце

Console.WriteLine("Введите номер задачи: ");
int task = Convert.ToInt32(Console.ReadLine());

switch(task)
{
    case 1:
        task1();
        break;
    
    case 2:
        task2();
        break;
    
    case 3:
        task3();
        break;
    
    default:
        break;
}


void task1()
{
    double[,] array = new double[3, 4];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble();
            array[i, j] = Math.Round(array[i, j], 2);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void task2()
{
    Console.WriteLine("Введите число: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число строк: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число столбцов: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[m, n];
    bool f = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 20);
            if (x == array[i, j]) 
                {m = i; n = j; f= true;}
            Console.Write(array[i, j] + " ");       
        }
    Console.WriteLine();
    
    if (f)
        {
            Console.WriteLine($"Позиции элемента: {m + 1} {n + 1}");
        }
    else
        {
            Console.WriteLine("Такого элемента нет");
        }
    
    }
}

void task3()
{        
    int[,] array = new int[3, 4];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine(array.GetLength(0));
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];            
        }
        double x = sum / array.GetLength(0);
    Console.Write($"{x = Math.Round(x, 2)}, ");
    }

}
