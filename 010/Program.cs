// Задача №10
// Вывести на экран последнюю цифру 
// целого числа введенного с клавиатуры.
int a;
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
int b=a%10;
System.Console.WriteLine(b);
