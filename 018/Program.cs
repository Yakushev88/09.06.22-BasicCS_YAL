// Задача №18
// По двум заданным числам проверять является ли одно квадратом другого. 
//Используйте подпрограмму.
// подпрограмма занимается только преобразованием входных данных в выходные данные.
bool Check(int a,int b)// подпрограмма. Начало
{
    return a*a==b;
} // подпрограмма. Конец
int a,b;
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
s=Console.ReadLine();
b=Convert.ToInt32(s);
// ==,!,=,<,>,<=,>=.
// Без точки с запятой с "else"
if(Check(a,b)) // Операция сравнения. 
{
    Console.WriteLine("b является квадратом a");
}
else
{
    if (Check(b,a))
    {
       Console.WriteLine("a является квадратом b"); 
    }
    else
    {
      Console.WriteLine("Числа не являются квадратами друг друга");  
    }
}