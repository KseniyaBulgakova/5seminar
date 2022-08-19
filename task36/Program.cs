// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
Console.Clear();
int[] Array=new int[5];
Random rand=new Random();
for (int i=0; i < Array.Length; i++ )
 { 
    Array[i]=rand.Next(0,1000);
 }
Console.Write('['+String.Join(',',Array)+']');  

int sum=0;
for (int z=0; z<Array.Length; z+=2)
sum = sum+Array[z];
Console.WriteLine($"Всего {Array.Length} элементов, сумма элементов на нечётных позициях = {sum}");