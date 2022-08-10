//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
void Zadacha34 ()
{
    Console.WriteLine ("Введите длину массива данных: ");
    int lenght = Convert.ToInt32 (Console.ReadLine ());
    int [] array1 = new int [lenght];
    FillArray (array1, 100, 1000);
    PrintArray (array1);
    int sum = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i] % 2 == 0) sum++;
    }
    Console.WriteLine ($"Количество чётных элементов в массиве = {sum}");
}

//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
void Zadacha36 ()
{
    Console.WriteLine ("Введите длину массива данных: ");
    int lenght = Convert.ToInt32 (Console.ReadLine ());
    int [] array36 = new int [lenght];
    FillArray (array36);
    PrintArray (array36);
    int sum = 0;
    for (int i = 1; i < array36.Length; i += 2)
    {
        sum += array36 [i];
    }
    Console.WriteLine ($"Сумма нечётных элементов массива = {sum}");
}

//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3,21 7,04 22,93 -2,71 78,24] -> 75,53
void Zadacha38 ()
{
    Console.WriteLine ("Введите длину массива данных: ");
    int lenght = Convert.ToInt32 (Console.ReadLine ());
    int [] array2 = new int [lenght];
    FillArray (array2, -999, 1000);
    //PrintArray (array2);
    double [] array38 = new double [lenght];
    for (int i = 0; i < lenght; i++)
    {
        array38 [i] = Math.Round ((array2 [i]*0.01), 2);
        Console.Write (array38 [i] + " ");        
    }
    double max = array38 [0];
    double min = array38 [0];
    for (int i = 1; i < lenght; i++)
    {
        if (array38 [i] > max) max = array38 [i];
        else if (array38 [i] < min) min = array38 [i];             
    }
    Console.WriteLine ($"Разница между максимальным значением ({max}) и минимальным значением ({min}) равна {max - min}");
}

void FillArray (int [] array, int StartNumber = -9, int FinishNumber = 9)
{
    Random rand = new Random ();
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = rand.Next (StartNumber, (FinishNumber+1));
    }
}

void PrintArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write (array[i] + " ");
    }
    Console.WriteLine ();
}
//Zadacha34 ();
//Zadacha36 ();
Zadacha38 ();
