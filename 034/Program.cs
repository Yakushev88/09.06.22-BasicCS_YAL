// 34. Задать массив из 12 элементов, заполненных 
// числами из [-9, 9]. 
// Найти сумму положительных/отрицательных элементов массива

/*
// Массив из 12-ти элементов от -9 до 9
int N=12;
int[] a=new int[N];
Random random=new Random();// Вводит случайные числа в тело массива 
for (int i=0; i<a.Length; i++)
    a[i]=random.Next(-9,10);
for (int i=0; i<a.Length; i++)
    System.Console.Write($"{a[i],4}");// 4- выделение знакомест перед выводимым символом
*/
/*
//Массив из случайных чисел от -9 до 9
// Сумма всех положительных и отрицательных элементов
int N=5;
int[] a=new int[N];
Random random=new Random();// Вводит случайные числа в тело массива 
for (int i=0; i<a.Length; i++)
    a[i]=random.Next(-9,10);
int sumPositive=0;
for (int i=0; i<a.Length; i++)
    if (a[i]>0)
        sumPositive=sumPositive+a[i];

System.Console.WriteLine(sumPositive);

for (int i=0; i<a.Length; i++)
    System.Console.WriteLine($"{a[i],4}");
*/

/*
//Сумма всех ТОЛЬКО положительных
int N=5;
int[] a=new int[N];
Random random=new Random();// Вводит случайные числа в тело массива 
for (int i=0; i<a.Length; i++)
    a[i]=random.Next(-9,10);
int sumPositive=0;
for (int i=0; i<a.Length; i++)
    if (a[i]>0)
        sumPositive=sumPositive+a[i];
    
System.Console.WriteLine(sumPositive);

for (int i=0; i<a.Length; i++)
    System.Console.WriteLine($"{a[i],4}");
*/

/*
//Сумма всех ТОЛЬКО отрицательных чисел
int N=5;
int[] a=new int[N];
Random random=new Random();// Вводит случайные числа в тело массива 
for (int i=0; i<a.Length; i++)
    a[i]=random.Next(-9,10);
int sumNegative=0;
for (int i=0; i<a.Length; i++)
    if (a[i]<0)
        //sumNegative=sumNegative+a[i];
        sumNegative+=a[i];
System.Console.WriteLine(sumNegative);

for (int i=0; i<a.Length; i++)
    System.Console.WriteLine($"{a[i],4}");
*/


// Сумма и положительных и отрицательных чисел ВМЕСТЕ

int N=12;
int[] a=new int[N];
Random random=new Random();// Вводит случайные числа в тело массива 
for (int i=0; i<a.Length; i++)
    a[i]=random.Next(-9,10);

int sumPositive=0;
for (int i=0; i<a.Length; i++)
    if (a[i]>0)
        sumPositive=sumPositive+a[i];
    
System.Console.WriteLine(sumPositive);

int sumNegative=0;
for (int i=0; i<a.Length; i++)
    if (a[i]<0)
        //sumNegative=sumNegative+a[i];
        sumNegative+=a[i];// ТО ЖЕ САМОЕ ЧТО СТРОЧКА ВЫШЕ
System.Console.WriteLine(sumNegative);

for (int i=0; i<a.Length; i++)
    System.Console.Write($"{a[i],4}");





    
