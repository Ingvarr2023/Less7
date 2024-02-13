// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке
// от M до N. Использовать рекурсию, не использовать циклы.

Console.Write("Задайте натуральное число M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте натуральное число N: ");
int numN = Convert.ToInt32(Console.ReadLine());

void PrintNumbers(int numM, int numN)
{
    if (numM == numN)
    {
       Console.Write(numM);
        return;
    }
     Console.Write(numM + " ");
     PrintNumbers(numM + 1, numN);
}
PrintNumbers(numM, numN);

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// Функция Аккермана А(m,n) =   n+1; если m=0
//                              A(m-1,1) если m>0, n=0
//                              A(m-1, A(m, n-1)) если m>0, n>0

// Console.Write("Задайте неотрицательное число m: ");
// int numM = Convert.ToInt32(Console.ReadLine());
// Console.Write("Задайте неотрицательное число n: ");
// int numN = Convert.ToInt32(Console.ReadLine());

// int AckermannFunction(int numM, int numN)
// {
//     if (numM == 0)
//     {
//         return numN + 1;
//     }
//     else if (numM > 0 && numN == 0)
//     {
//         return AckermannFunction(numM - 1, 1);
//     }
//     else
//     {
//       return AckermannFunction(numM - 1, AckermannFunction(numM, numN - 1));
//     }
// }
// Console.WriteLine(AckermannFunction(numM,numN));


// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца.
//  Использовать рекурсию, не использовать циклы.

// int[] array = {1, 2, 5, 0, 10, 34};
//     int j = array.Length - 1;

// void ReverseArray(int[] array, int j)
// {
//     if (j == 0)
//     {
//     Console.Write(array[j]);
//     return;
//     }
// Console.Write(array[j] + ", ");
// ReverseArray(array, j - 1);
// }
// ReverseArray(array, j);

