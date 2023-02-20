// Задача 64: Выполнить с помощью рекурсии.Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"




// --------Method--------

// string GetNumbers (int N)
// {
//     if(N == 1) return N.ToString();
//     return ( N + " " + GetNumbers(N-1)); 
// }


// System.Console.Write("Введите число: ");
// int N = int.Parse(Console.ReadLine()!);
// Console.Write(GetNumbers(N));


// _______________________________________________________________________________
// Задача 66: Выполнить с помощью рекурсии.Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// ------------Method-----------
// int GetSum (int from, int to)
// {
//     if(from == to) return to;
//     else return from + GetSum(from + 1,to);
// }

// System.Console.Write("Введите число М:");
// int M = int.Parse(System.Console.ReadLine()!);
// System.Console.Write("Введите число N:");
// int N = int.Parse(System.Console.ReadLine()!);

// Console.WriteLine(GetSum(M,N));



// _______________________________________________________________________________
// Задача 68: Выполнить с помощью рекурсии.Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введи число m: ");
int m  = int.Parse(Console.ReadLine()!);
Console.Write("Введи число n: ");
int n  = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Функция Аккермана для чисел {m} и {n}: {Akkerman(m,n)}");

//----------Метод---------
int Akkerman(int m, int n){
    if(m==0) return n+1;
    if(n==0) return Akkerman(m-1,1);
    return Akkerman(m-1, Akkerman(m, n-1));
}