// 43. Определить сколько чисел 
//больше 0 введено с клавиатуры

//int n=int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите числа положительные и отрицательные"); 
string s=Console.ReadLine();
string[] ss=s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
int[] a=Array.ConvertAll<string,int>(ss, int.Parse);
int k=0;
for(int i=0;i<a.Length; i++)
        if (a[i]>0)
            k++;
System.Console.WriteLine("Количество цыфр больше нуля:");
System.Console.WriteLine(k);
