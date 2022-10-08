// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько 
//чисел больше 0 ввёл пользователь.
/*Console.Write("Сколько чисел вы будете вводить? ");
int n = Convert.ToInt32(Console.ReadLine());
int[] Mass = new int[n];
//int i = 0;
for(int i = 0; i < n; i++)
{
    Console.WriteLine("Введите {0}-ое число", i + 1);
    Mass[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Среди чисел:");
for(int i = 0; i < n; i++)
{
   Console.Write($"{Mass[i]}  "); 
}
Console.WriteLine();
int j = 0;
for (int i = 0; i < Mass.Length; ++i) 
    if (Mass[i] > 0) 
        j++;  
Console.WriteLine($"положительных:  " + (j) );
*/



//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
//задаются пользователем.
Console.Write("Для уравнения y = k1 * x + b1 введите k1:  ");
double a = Convert.ToInt32(Console.ReadLine());
Console.Write("введите b1: ");
double b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Для уравнения y = k2 * x + b2 введите k2:  ");
double c = Convert.ToInt32(Console.ReadLine());
Console.Write("введите b2: ");
double d = Convert.ToInt32(Console.ReadLine());
double solutx = (d - b) / (a -c);
//int soluty = a * solutx + b;
double soluty = c * solutx + d;
Console.WriteLine();
Console.WriteLine($"Уравнения y = {a} * x + {b}  и  y = {c} * x +{ d}");
Console.WriteLine($"пересекутся в точке А({Math.Round(solutx,2)}; {Math.Round(soluty,2)})");
