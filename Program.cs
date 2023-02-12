﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.  
//Напишите программу, которая покажет количество чётных чисел в массиве. 
//[345, 897, 568, 234] -> 2 
 
 
int[] arr = new int[10]; 
for (int i = 0; i < 10; i++) 
{ 
    arr[i] = new Random().Next(100, 1000); 
} 
Console.WriteLine(string.Join(",", arr)); 
int Count = 0; 
for (int i = 0; i < 10; i++) 
{ 
    if (arr[i] % 2 == 0) Count += 1; 
} 
Console.WriteLine($"Количество четных чисел = {Count}");