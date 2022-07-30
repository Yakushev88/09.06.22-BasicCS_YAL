// 36. Определить, присутствует ли в заданном 
//массиве, некоторое число?

int N=12;
int[] a=new int[N];
Random random=new Random();// Вводит случайные числа в тело массива 
for (int i=0; i<a.Length; i++)
    a[i]=random.Next(-9,10);

//решение задачи
int f=400;
//a[3]=f;
//Линейный поиск
int j=0;
while (j < a.Length && a[j]!=f) j++;
if (j==a.Length) System.Console.WriteLine("\nNot found");
//else System.Console.WriteLine($"Element {f} findet at {j}");
else System.Console.WriteLine($"\nElement {f} findet at {j}");

for (int i=0; i<a.Length; i++)
    System.Console.Write($"{a[i],4}");