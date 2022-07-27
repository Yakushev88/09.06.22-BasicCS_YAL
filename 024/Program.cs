// Показать таблицу квадратов чисел от 1 до N

double N=20; 
double i=1;
double iq=1;
while(i<=N) 
{
    iq=Math.Pow(i,2);
    System.Console.WriteLine($"{iq} ");
    i=i+1; 
}
