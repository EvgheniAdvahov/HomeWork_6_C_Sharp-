// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

// System.Console.WriteLine("Введите кол-во чисел: ");
// int M = Convert.ToInt32(Console.ReadLine());
// int[] Myarray = new int[M];

// for (int i = 0; i < M; i++)
// {
//     System.Console.WriteLine($"Введите {i+1} число ");
//     Myarray[i] = Convert.ToInt32(Console.ReadLine());
// }

// int count =0;
// for (int i = 0; i < M; i++)
// {
//     if(Myarray[i]>0) count++;
// }

// System.Console.WriteLine(String.Join(",",Myarray));
// System.Console.WriteLine($"Количество чисел больше 0 = {count}");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

double Input(string variableName)
{
    double arg;
    System.Console.Write($"Введите {variableName} : ");
    arg = Convert.ToDouble(Console.ReadLine());
    return arg;
}

double k1 = Input("k1");
double b1 = Input("b1");
double k2 = Input("k2");
double b2 = Input("b2");

double x = -((b1 - b2) / (k1 - k2));
double y = (k1 * x) + b1;

System.Console.WriteLine($"({Math.Round(x, 1)};{Math.Round(y, 1)})");

