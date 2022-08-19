// Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
Console.Clear();
int[] Array=new int[5];
Random rand=new Random();
for (int i=0; i < Array.Length; i++ )
 { 
    Array[i]=rand.Next(0,150);
 }
Console.Write('['+String.Join(',',Array)+']');  
int count=0;
for (int z=0; z< Array.Length; z++ )
 if (z>10 && z<100 )
    count= count+Array[z];
Console.WriteLine($"Всего элементов:  {Array.Length} ;  Лежат на отрезке (10,99): {count} ");
