/*
int a = 1245;
Console.WriteLine(a);
Console.WriteLine("Hello World!");
Console.WriteLine(13%4);
string s = "Hello"+"abc";//конкотенация строк (склеивание)
Console.WriteLine(s); 
char c = 'a';
System.Console.WriteLine(int.MaxValue);
System.Console.WriteLine(double.MaxValue);
*/
// Задача №1

int a;
int b;
string? s=Console.ReadLine(); //Присваиваем стринг. ВВОД ДАННЫХ
a=Convert.ToInt32(s); // конвертируем стринг в интеджер. Позволяет вводить любое целое число вместо надписи
b=a*a; // ОБРАБОТКА ДАННЫХ
//Console.WriteLine(b);

// Два способа ВЫВОД НА ЭКРАН
Console.WriteLine("{0}^2={1}",a,b); //строка форматирования
Console.WriteLine($"{a}^2={b}"); // строка интерполяции

/*
string? s; // объявили переменную
s=Console.ReadLine(); // присвоили
Console.WriteLine(s);
*/