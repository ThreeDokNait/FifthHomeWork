Console.Clear();


// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] array = new int[5];
// int count = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(99, 1000);
//     System.Console.Write(array[i]+ ", ");
// }
// System.Console.WriteLine();
// while (count<array.Length)
// {
//     if (array[count]%2==0)
//     {
//         System.Console.WriteLine(array [count] + " ");
//     }
//     count++;
// }


// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] array = new int[8];
// int count = 1;
// int sum = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0, 10);
//     System.Console.Write(array[i]+ ", ");
// }
// System.Console.WriteLine();
// while (count<array.Length)
// {

//     sum = sum + array[count];
//     count = count+2;
// }
// System.Console.WriteLine(sum);


// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и 
// минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// double[] array = new double[3];

// double max = array[0];
// double min = array[0];
// int t = 0;
// double diff = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = (new Random().Next(10, 20) +new Random().NextDouble());
//     System.Console.Write(array[i] + "; ");
// }
// System.Console.WriteLine();
// while (t < array.Length)
// {
//     if (array[t] < min)
//     {
//         min = array[t];
//     }

//     if (array[t] > max)
//     {
//         max = array[t];
//     }

//     t++;
// }

// diff = (max - min);
// System.Console.WriteLine("разница ="+ diff);