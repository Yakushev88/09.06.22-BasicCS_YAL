//Вводиться число N, а затем - N чисел. 
// Выведите N чисел в следующем порядке:
// Сначала выводятся все нечетные числа в том порядке,
// в котором они встречались во входном файле
// а затем все четные
// вводиться число N (100>N>0) а затем N чисел
// из диапазона Integer

//using System; // Пространство имён
int n=int.Parse(Console.ReadLine()); // Первая строка
string s=Console.ReadLine(); //Вторая строка для ввода
// s=s.Trim(); // Удалить пробелы в начале и в конце строки
string[] ss=s.Split(' ');
int[] a=Array.ConvertAll<string,int>(ss, int.Parse);
for (int i=0; i< a.Length; i++)
    if (a[i] %2 ! = 0)
    System.Console.WriteLine($"{a[i]}");

for (int j=0; j< a.Length; j++)
    if (a[j] %2 == 0)
    System.Console.WriteLine($"{a[j]}");