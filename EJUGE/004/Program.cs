// // Вводиться число N, а затем - N чисел. Определитьб сколько 
// среди них пар одинаковых чисел.
// 100>=N>=2
// Пример входнеого файла:
//5
//1 3 2 2 3
/*
int n=int.Parse(Console.WriteLine()); //то же что Convert
string s="0 0 6 1 1 4 2 1 2 2";//Console.ReadLine();
string[] ss=s.Split(' ');// создает массив строк
// конвертация всего, в скобках <> первое что
// преобразовываем, на втором месте во что
// далее имя массива (ss), и метод преобразования

int[] a=Array.ConvertAll<string,int>(ss, int.Parse);

// через КонвертАлл получим массив целых чисел из
// массива строк
// Два цикла, один сравнивает

int k=0;
for(int i=0;i<a.Lenght; i++)
{
    for(int j=i+1; j<a.Length; j++)
    if(a[i]==a[j])
    k++;
}
System.Console.WriteLine(k);
*/
/*
int n=int.Parse(Console.ReadLine()); 
string s="1 5 8 5 5";//Console.ReadLine();
string[] ss=s.Split(' ');
int[] a=Array.ConvertAll<string,int>(ss, int.Parse);
int k=0;
for(int i=0;i<5; i++)
    for(int j=i+1; j<5; j++)
        if (a[i]==a[j])
            k++;

System.Console.WriteLine(k);
*/


// Вводиться число N, а затем - N чисел. Определитьб сколько 
// среди них пар одинаковых чисел.
int n=int.Parse(Console.ReadLine()); 
string s=Console.ReadLine();
string[] ss=s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
int[] a=Array.ConvertAll<string,int>(ss, int.Parse);
int k=0;
for(int i=0;i<a.Length-1; i++)
        if (a[i]==a[i+1])
            k++;
System.Console.WriteLine(k);
