// Задача №4
// По заданному с клавиатуры номеру дня недели 
// вывести его название
/*
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
*/
/*
int dayOfWeek= Convert.ToInt32(Console.ReadLine());
// int DayOfWeek; - Pascal Case
if (dayOfWeek==1) System.Console.WriteLine("Monday");
if (dayOfWeek==2) System.Console.WriteLine("Tuesday");
if (dayOfWeek==3) System.Console.WriteLine("Wednesday");
if (dayOfWeek==4) System.Console.WriteLine("Thursday");
if (dayOfWeek==5) System.Console.WriteLine("Friday");
if (dayOfWeek==6) System.Console.WriteLine("Saturday");
if (dayOfWeek==7) System.Console.WriteLine("Sunday");
  if (dayOfWeek==1) System.Console.WriteLine("Monday");
else
   if (dayOfWeek==2) System.Console.WriteLine("Tuesday");
   else
*/

// Swithcase
/*
int dayOfWeek= Convert.ToInt32(Console.ReadLine());
switch(dayOfWeek)
{
  case 1:
        System.Console.WriteLine("Monday");
        break;
  case 2:
        System.Console.WriteLine("Tuestday");
        break;
  case 3:
        System.Console.WriteLine("Wednesday");
        break;
  default:
        System.Console.WriteLine("Wrong");
        break;
}
*/
// Пропробовать через массивы!!!

System.Console.WriteLine("Введите порядковый номер дня недели: ");
int numbersDoF= Convert.ToInt32(Console.ReadLine());
// Задаем строковой массивю Сразу наполнили.
string[] weekDays = new string[] {"Monday" , "Tuesday" , "Wednesday" , "Thurstday" ,"Friday" , "Saturday" ," Sunday" ,};
System.Console.WriteLine(weekDays[numbersDoF-1]);
// -1, т.к массив индексируется с 0