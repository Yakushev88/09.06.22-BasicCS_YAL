// Задача №15
// С клавиатуры вводится целое число. Вывести третью цифру числа 
// или сообщить, что её нет.
int a;
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
int b=a%10;
System.Console.WriteLine(b);