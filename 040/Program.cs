// 40. Найти произведение пар чисел в одномерном 
//массиве. Парой считаем первый и последний элемент,
// второй и предпоследний и т.д.

int N=13;
int[] a=new int[N];
Random random=new Random();// Вводит случайные числа в тело массива 
for (int i=0; i<a.Length; i++)
    a[i]=random.Next(1,11);

for (int i=0; i<a.Length; i++)
System.Console.Write($"{a[i],4}");

// Решение задачи
int[] b=new int[a.Length/2]; // понимаем, что новый массив 
// будет короче предыдущего в два раза
for (int i=0; i<a.Length/2; i++)
b[i]=a[i]*a[a.Length-i-1];

//Вывод массива на экран после вычислений
System.Console.WriteLine();
for (int i=0; i<b.Length; i++)
System.Console.Write($"{b[i],4}");

