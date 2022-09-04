// Задача 64: Задайте значения M и N. Напишите программу, которая выведет 
//все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""


// Console.Clear();
// Console.Write("Введите начальное натуральное значение M: ");
// int m = int.Parse(Console.ReadLine());
// Console.Write("Введите конечное натуральное значение N: ");
// int n = int.Parse(Console.ReadLine());
// if (n < m || m < 0)
// {
//     Console.Write("Введите начальное натуральное значение M: ");
//     int m1 = int.Parse(Console.ReadLine());
//     Console.Write("Введите конечное натуральное значение N: ");
//     int n1 = int.Parse(Console.ReadLine());
//     n = n1; m = m1;
//     Console.WriteLine($"M={m}; N={n}->''{StringNumbers1(m, n),2}''");
//     string StringNumbers1(int firstnumber, int secondnumber)
//     {
//         if (firstnumber == secondnumber) return firstnumber.ToString();
//         return (firstnumber + " ," + StringNumbers1(firstnumber + 1, secondnumber));
//     }
// }
// else
// {
//     Console.WriteLine($"M={m}; N={n}->''{StringNumbers(m, n),2}''");
//     string StringNumbers(int firstnumber, int secondnumber)
//     {
//         if (firstnumber == secondnumber) return firstnumber.ToString();
//         return (firstnumber + " ," + StringNumbers(firstnumber + 1, secondnumber));
//     }
//     return;
// }

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
//натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
// Console.Clear();
// Console.Write("Введите начальное натуральное значение M: ");
// int m = int.Parse(Console.ReadLine());
// Console.Write("Введите конечное натуральное значение N: ");
// int n = int.Parse(Console.ReadLine());
// if (n < m || m < 0)
// {
//     Console.Write("Введите начальное натуральное значение M: ");
//     int m1 = int.Parse(Console.ReadLine());
//     Console.Write("Введите конечное натуральное значение N: ");
//     int n1 = int.Parse(Console.ReadLine());
//     n = n1; m = m1;
//     Console.WriteLine($"M={m}; N={n}-> {SumNumbers1(m, n),2}");
//     int SumNumbers1(int firstnumber, int secondnumber)
//     {
//         if (firstnumber == secondnumber) return secondnumber;
//         return (firstnumber + SumNumbers1(firstnumber + 1, secondnumber));
//     }
// }
// else
// {
//     Console.WriteLine($"M={m}; N={n}-> {SumNumbers(m, n),2}");
//     int SumNumbers(int firstnumber, int secondnumber)
//     {
//         if (firstnumber == secondnumber) return secondnumber;
//         return (firstnumber + SumNumbers(firstnumber + 1, secondnumber));
//     }
//     return;
// }

