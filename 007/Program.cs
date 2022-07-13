// Задача №7
// Выяснить является ли число чётным.
int a;
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
if (a%2==0) // ПРОВЕРЯЕМ ДЕЛИТЬСЯ ЛИ ЧИСЛО НА 2 БЕЗ ОСТАТКА
    {
    System.Console.Write("Число является чётным");
    }
else
System.Console.Write("Число является не чётным");
