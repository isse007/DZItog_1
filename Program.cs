// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

void PrintNumber (int M, int N)
{
    // System.Console.WriteLine($"Числа от M {M} до N {N}");
    System.Console.WriteLine($"{M}");
    if (N==M) 
    {
        return;
    }
    PrintNumber (M+1,N);
    
}

 PrintNumber (5,9);