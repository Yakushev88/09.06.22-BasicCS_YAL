// 26. Найти сумму чисел от 1 до А(-)

int A=10;
int[] a=new int[A];
Random random=new Random();// Вводит случайные числа в тело массива 
for (int i=1; i<a.Length-1; i++)
    a[i]=random.Next(0,10);

for (int i=1; i<a.Length-1; i++)
    System.Console.Write($"{a[i],4}");

int sum=0;
for (int i=1; i<a.Length;i++)
    sum=sum+a[i];
System.Console.WriteLine();
System.Console.Write(sum);