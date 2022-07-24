// Задача №13. 
//Удалить вторую цифру(с конца) целого числа введенного 
//с клавиатуры.
//ВАРИНАТЫ С УДАЛЕНИЯ С КОНЦА
/*
int n = 123; //Получим каждую цыфру
int d0=n%10; //Первая цифра (с конца)
int d1=n/10%10; // Втрая цифра
int d2=n/100%10; // Третья цыфра с конца

System.Console.WriteLine($"{d2}{d1}{d0}");
*/
/*
// Сотни перевернутые
int n = Convert.ToInt32(Console.ReadLine()); //Получим каждую цыфру
int d0=n%10; //Первая цифра (с конца)
int d1=n/10%10; // Втрая цифра
int d2=n/100%10; // Третья цыфра с конца
int n1=d2*10+d0;
System.Console.WriteLine($"{d0}{d1}{d2}"); // Переворот через изменение порядка написанияб через команду вывод
*/
/*
//Десятки
int n = Convert.ToInt32(Console.ReadLine()); //Получим каждую цыфру
int d0=n%10; //Первая цифра (с конца)
int d1=n/10%10; // Вторая цифра
int d2=n/100%10; // Третья цыфра с конца
int n1=d2*10+d0;
//System.Console.WriteLine($"{d0}{d1}{d2}"); // Переворот через изменение порядка написанияб через команду вывод
System.Console.WriteLine($"{n1}");
*/
/*
//Тысячи
int n = Convert.ToInt32(Console.ReadLine()); //Получим каждую цыфру
int d0=n%10; 
int d1=n/10%10; 
int d2=n/100; // !!!
int n1=d2*10+d0;
System.Console.WriteLine($"{n1}");
*/

// ВАРИАНТЫ УДАЛЕНИЯ С НАЧАЛА
// Предварительно производиться подсчет количества цыфр в числе
// Заданное число
/*
int n = 976542786;
int k = DigitsCount(n);
// 6789 = (int)Math.Pow(10,k-2)
int n2=n%(int)Math.Pow(10,k-2); // !!! Явное приведение типов
// (int)Math.Pow(10,k-1) = 4
int n3 = n/(int)Math.Pow(10,k-1);
System.Console.WriteLine($"{n3}{n2}");

int DigitsCount(int N) // подпрограма
{
    int k=0;
 while (N!=0)
{
    k=k+1;
    N=N/10;
}
return k;
}
*/
// Ввод с клавиатуры

// Заданное число
int n = Convert.ToInt32(Console.ReadLine());
int k = DigitsCount(n);
// 6789 = (int)Math.Pow(10,k-2)
int n2=n%(int)Math.Pow(10,k-2); // !!! Явное приведение типов
// (int)Math.Pow(10,k-1) = 4
int n3 = n/(int)Math.Pow(10,k-1);
int nn=n3*(int)Math.Pow(10,k-2)+n2;
//Если постаить в (10,k-2) k-1, вторая
// цыфра в числе меняется на "0" 
//System.Console.WriteLine($"{n3}{n2}");
System.Console.WriteLine(nn);
int DigitsCount(int N) // подпрограма
{
    int k=0;
 while (N!=0)
{
    k=k+1;
    N=N/10;
}
return k;
}
