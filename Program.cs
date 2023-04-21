// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами (длина массива 5 элементов). Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] array = new int[5];
// int evenNumber = 0;
// RandomArray(array); // рандомные числа
// PrintRandomArray(array); // печать рандомные числа
// PrintEvenNumber(array, evenNumber); // подсчет количество четных чисел

// void RandomArray(int[] array)
// {
// for (int i = 0; i < array.Length; i++) 
// {
//     int randomNumber = new Random().Next (100, 999);
//     array[i] = randomNumber; 
// }
// }
// void PrintRandomArray(int[] array)
// {
// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write(array[i] + " ");
// }
// }
// void PrintEvenNumber(int[] array, int evenNumber)
// {
// for (int i = 0; i < array.Length; i++) 
// {
//   if (array[i] % 2 == 0)
//   {
//     evenNumber += 1;
//   }
//   else
//   {
//     continue;
//   }
// }
// Console.WriteLine($"количество чётных чисел в массиве = {evenNumber}");
// }




// Задача 36: Задайте одномерный массив, заполненный случайными числами (длина массива 5 элементов). Найдите сумму элементов, стоящих на нечётных индексах (индексы с нуля).
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] array = new int[5];
// int oddSum = 0;
// RandomArray(array); // рандомные числа
// PrintRandomArray(array); // печать рандомные числа
// PrintEoddSum(array, oddSum); // подсчет суммы элементов, стоящих на нечётных индексах

// void RandomArray(int[] array)
// {
// for (int i = 0; i < array.Length; i++) 
// {
//     int randomNumber = new Random().Next (-20, 20);
//     array[i] = randomNumber; 
// }
// }
// void PrintRandomArray(int[] array)
// // {
// // for (int i = 0; i < array.Length; i++)
// // {
// //     Console.Write(array[i] + " ");
// // }
// // }
// void PrintEoddSum(int[] array, int ddSum)
// {
// for (int i = 0; i < array.Length; i++) 
// {
//   if (i % 2 == 0)
//   {
//     continue;
//   }
//   else
//   {
//     oddSum += array[i];
//   }
// }
// Console.WriteLine($"сумму элементов, стоящих на нечётных индексах = {oddSum}");
// }




// Задача 38: Задайте массив вещественных чисел от -100 до 100 (длина массива 5 элементов). Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = new double[5];
double diffMaxMin = 0;
double min = array[0];
double max = min;

RandomArray(array); // рандомные числа
PrintRandomArray(array); // печать рандомные числа
FaindMin(array, min); // минимал значение
FaindMax(array, max); // макс значение
PrintDiffMaxMin(diffMaxMin, max, min); // разница между максимальным и минимальным элементом массива

void RandomArray(double[] array)
{
for (int i = 0; i < array.Length; i++) 
{
    int randomNumber = new Random().Next (-100, 100);
    array[i] = randomNumber; 
}
}
void PrintRandomArray(double[] array)
{
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
}

double FaindMin(double[] array, double min)
{
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] <= min)
    {
      min = array[i];
      return min;
    }
  }
  return min;
}

double FaindMax(double[] array, double max)
{
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] >= max)
    {
      max = array[i];
      return max;
    }
  }
  return max;
}

void PrintDiffMaxMin(double max, double min, double diffMaxMin)
{
diffMaxMin += (max - min);
Console.WriteLine($" разницу между максимальным {max} и минимальным {min} элементами массива = {diffMaxMin}");
}















// Доп. задачи
// Задача 3: Задайте массив из 8 случайных чисел из промежутка [-9, 9]. Напишите программу получает на вход число и определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

// Задача 4: Задайте массив из 10 случайных чисел из промежутка [-100, 100]. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 10 элементов. В своём решении сделайте для 10
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5