// 39. Найти сумму чисел одномерного массива 
//стоящих на нечетной позиции

// инициализация массива
int N=10;
int[] a=new int[N];
Random random=new Random();// Вводит случайные числа в тело массива 
for (int i=1; i<a.Length-1; i++)
    a[i]=random.Next(0,10);

// Вывод массива до обработки
for (int i=1; i<a.Length-1; i++)
    System.Console.WriteLine($"{a[i],4}");

// Решение задачи
int sum=0;
for (int i=1; i<a.Length;i=i+2)
    sum=sum+a[i];
System.Console.Write(sum);