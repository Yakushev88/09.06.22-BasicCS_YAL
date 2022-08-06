// 44. Написать программу преобразования 
//десятичного числа в двоичное
/*
int n=345; //1111

while (n!=0)
{
    s=s+(n%2);
    System.Console.Write(n%2);
    n/=2; //n=n/2
}
*/
/*
int n=16; //1111
string s="";
while (n!=0)
{
    s=s+(n%2);
    n/=2; //n=n/2
}
System.Console.Write(s);
*/

/*
// Через подпрограмму
int n=16; //1111

System.Console.Write(DecToBin(n));
string DecToBin(int n)
{
string s="";
while (n!=0)
    {
        s=s+(n%2);
        n/=2; //n=n/2
    }
    return s;
}
*/

/*
// Вывод в таблицу Код для двоичной системы
int n=16; //1111

for(int i=0; i<20; i++)
    System.Console.WriteLine($"{i} {DecToBin(i)}");

System.Console.Write(DecToBin(n));
string DecToBin(int n)
{
if (n==0) return "0";
string s="";
while (n!=0)
    {
        s=s+(n%2);
        n/=2; //n=n/2
    }
        return s;
}
*/

// Адаптация программы для любой стсиемы исчисления

int n=16;//1111

for(int i=0;i<20;i++)
    System.Console.WriteLine($"{i} {DecToAny(i,15)}");


string DecToBin(int n)
{
    if (n==0) return "0";
    string s="";
    while (n!=0)
    {
        s=(n%2).ToString()+s;    
        n/=2;//n=n/2
    }
    return s;
}

string DecToAny(int n,int @base)
{
    if (@base>10) {
        //System.Console.WriteLine("Основание должно быть не больше 10");
        throw new ArgumentOutOfRangeException("Основание должно быть не больше 10");        
    }
    if (n==0) return "0";
    string s="";
    while (n!=0)
    {
        s=(n%@base).ToString()+s;    
        n/=@base;//n=n/2
    }
    return s;
}