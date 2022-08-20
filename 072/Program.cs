// 72. Написать программу возведения числа А в целую степень B

int a=2;
int b=4;

int P(int a, int b)
{
    if (b==0) return 1;
    else return P(a,b-1)*a;
}
System.Console.WriteLine(P(a,b));