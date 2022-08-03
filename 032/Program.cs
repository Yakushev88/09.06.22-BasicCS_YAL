// Задача №32
// Задать массив из 8 элементов и вывести их на экран
/*
int[] t; //// Объявили масив
t= new int[8];
 t[0]=10;
 t[1]=12;
 // Инициализация
 for(int i=0;i<t.Length; i++)
    t[i]=i*12;
// решение задачи

//вывод результатов на экран
 for(int i=0;i<t.Length; i++)
    System.Console.WriteLine($"a[{i}]={t[i]} ");
*/

// Решение данной задачи с помощью подпрограммы
int[] t; //// Объявили масив
Init(out t,8, max:100);
 t[0]=10;
 t[1]=12;
 // Инициализация
 for(int i=0;i<t.Length; i++)
    t[i]=i*12;
// решение задачи

//вывод результатов на экран
Print(t);
/*
 for(int i=0;i<t.Length; i++)
    System.Console.WriteLine($"a[{i}]={t[i]} ");
 */
void Init(out int[] t, int Length, int min=0, int max=10)
{
   t=new int[Length];
   Random random=new Random();
   for(int i=0;i<t.Length; i++)
      t[i]=random.Next(min,max+1);
}

 // Вывод на экран в виде метода

void Print(int[] t)
{
   for(int i=0;i<t.Length; i++)
   System.Console.WriteLine($"a[{i}]={t[i]}");
}


