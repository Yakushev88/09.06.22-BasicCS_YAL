//Вводиться число N, а затем - N чисел. 
// Выведите N чисел в обратном порядке
// Входные данные 
// Выведите N чисел в обратном порядке
// 100>=N>=2
// Пример входнеого файла:
//7
//2 4 1 3 5 3 1
// Пример выходнеого файла:
// 1 3 5 3 1 4 2
/*
int n=int.Parse(Console.ReadLine()); // Первая строка
string s=Console.ReadLine(); //Вторая строка для ввода
string[] ss=s.Split(' '); // Преобразуем строку в массив строк
//Преобразуем массив строк в массив int
int[] a=Array.ConvertAll<string,int>(ss, int.Parse);
// Решение
for (int i=0; i< a.Length/2; i++)
{
    int tmp =a[i]; // Временная переменная
    // меняем нулевой на последний
    a[i] = a[a.Length-i-1]; // -i что бы не выйти за границы массива
    a[a.Length-i-1]=tmp; // меняем последний на нулевой
}
for (int i=0; i < a.Length; i++)// перебор по всему массиву
{
   System.Console.Write(a[i]+" "); 
}
*/
/*
// Через строковой тип
// Преворачиваем строковой массив

int n=int.Parse(Console.ReadLine()); // Первая строка
string s=Console.ReadLine(); //Вторая строка для ввода
string[] a=s.Split(' ',StringSplitOptions.RemoveEmptyEntries); // Преобразуем строку в массив строк
//Преобразуем массив строк в массив int
//int[] a=Array.ConvertAll<string,int>(ss, int.Parse);
// Решение
for (int i=0; i< a.Length/2; i++)
{
    string tmp =a[i]; // Временная переменная
    // меняем нулевой на последний
    a[i] = a[a.Length-i-1]; // -i что бы не выйти за границы массива
    a[a.Length-i-1]=tmp; // меняем последний на нулевой
}
for (int i=0; i < a.Length; i++)// перебор по всему массиву
{
   System.Console.Write(a[i]+" ");
} 
*/

//преворот без подпрограммы перворота массива

int n=int.Parse(Console.ReadLine()); // Первая строка
string s=Console.ReadLine(); //Вторая строка для ввода
string[] a=s.Split(' ',StringSplitOptions.RemoveEmptyEntries); // Преобразуем строку в массив строк
//Преобразуем массив строк в массив int
//int[] a=Array.ConvertAll<string,int>(ss, int.Parse);
// Решение
/*
for (int i=0; i< a.Length/2; i++)
{
    string tmp =a[i]; // Временная переменная
    // меняем нулевой на последний
    a[i] = a[a.Length-i-1]; // -i что бы не выйти за границы массива
    a[a.Length-i-1]=tmp; // меняем последний на нулевой
}
*/
for (int i=a.Length-1; i>=0; i--)// перебор по всему массиву
{
   System.Console.Write(a[i]+" ");
}
