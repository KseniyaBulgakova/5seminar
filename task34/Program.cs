// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
Console.Write("Введите размер массива ");
int K=Convert.ToInt32(Console.ReadLine());
int[] Array=new int[K];
Random rand=new Random();
for (int i=0; i < K; i++ )
 {
     Array[i]=rand.Next(111,1000);
 }
Console.Write('['+String.Join(',',Array)+']');  

int count=0;
for (int z = 0; z < Array.Length; z++)
{
    if (Array[z] % 2 == 0)
count++;
}
Console.WriteLine($"Всего:  {Array.Length} ;  чётных из них: {count} ");