// Задача №2
//С клавиатуры вводятся два вещественных числа. 
//Проверять является ли одно из них квадратом второго (блок-схема)

/*
if(2*2==4); //полное условие
{

}
else
{
    // false
}

if (2*2==4) // не полное условие
{
    //
}
*/

int a,b;
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
s=Console.ReadLine();
b=Convert.ToInt32(s);
// ==,!,=,<,>,<=,>=.
if(a*a==b); // Операция сравнения. 
{
    Console.WriteLine("b является квадратом a");
}
else
{
    if (b*b==a)
    {
       Console.WriteLine("a является квадратом b"); 
    }
}