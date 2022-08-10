// Задача №12
// Дано число из  диапозона  [10, 99]. 
//Показать наибольшую цифру числа

int N=1;
int[] a=new int[N];
Random random=new Random();// Вводит случайные числа в тело массива 
for (int i=0; i<a.Length; i++)
    a[i]=random.Next(10,99);
for (int i=0; i<a.Length; i++)
    System.Console.Write($"{a[i],4}");