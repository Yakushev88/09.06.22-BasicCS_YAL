//25. Найти кубы чисел от 1 до N

double N=15; 
double i=1;
double iq=1;
while(i<=N) 
{
    iq=Math.Pow(i,3);
    System.Console.Write($"{iq} ");
    i=i+1; 
}