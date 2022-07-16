// Задача №15
// С клавиатуры вводится целое число. Вывести третью цифру числа 
// или сообщить, что её нет.
int a;
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
if (a>99)
    {
    System.Console.WriteLine((a/10000)%10);
    }
else
    {
        System.Console.WriteLine("Третьей цыфры введенного числа - нет");
    }
