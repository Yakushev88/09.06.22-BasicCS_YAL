// 46. Показать числа Фибоначчи

Console.WriteLine("До какого порядка вычислять ряд Фибоначчи?");
int numbers = Convert.ToInt32(Console.ReadLine());
int a = 1;
Console.Write("{0} ", a);
int b = 1;
Console.Write("{0} ", b);
int sum = 0;
while (numbers >= sum)
{
    sum = a + b;           
    Console.Write("{0} ", sum);              
    a = b;
    b = sum;                
}