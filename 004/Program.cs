// Задача №4
// По заданному с клавиатуры номеру дня недели 
// вывести его название
int a;
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
if (a==1);
    {
  System.Console.Write("Monday");
    }
    
    if (a==2);
    {
    System.Console.Write("Tuesday");
    }
    if (a==3);
    {
    System.Console.Write("Wednesday");
    }
    if (a==4);  
    {
    System.Console.Write("Thursday");
    }
    if (a==5);
    {
    System.Console.Write("Friday");
    }
    if (a==6);
    {
    System.Console.Write("Saturday");
    }
    if (a==7);
    {
    System.Console.Write("Sunday");
    }