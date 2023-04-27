﻿int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int [size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
}

bool CheckNumber (int num, int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] == num) return true;
    }
    return false;
}


int[] array = CreateArrayRndInt(5, -9, 9);
Console.Write("[");
PrintArray(array);
Console.Write("]");
Console.WriteLine();
Console.WriteLine("Напишите число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool checkNumber = CheckNumber(number, array);
Console.WriteLine(checkNumber ? "Да" : "Нет");