// Задача №16 
// Дано число. Проверить кратно ли оно 7 и 23
/*
bool b; // Новый тип данных. Истина или ложь
b=true;
b=false;
b=23*29>5;
System.Console.WriteLine(b);
*/
// проверка кратности по отдельности
/*
bool a,b;
int x=21;
a=x%7==0;
b=x%23==0;
System.Console.WriteLine(x);
System.Console.WriteLine(a);
System.Console.WriteLine(b);
*/
// Проверка кратности по первому и второму
// и по обоим вместе
bool a,b,c;
int x=23;
a=x%7==0;
b=x%23==0;
c=a && b; // Сложное условие. Можно инверсировать
// c=!(a && b); !-НЕ (логический оператор)
System.Console.WriteLine(x);
System.Console.WriteLine(a);
System.Console.WriteLine(b);
System.Console.WriteLine(c);

// & - И; | - ИЛИ; ^ - исключающее ИЛИ; 
// && - укороченное И; || - укороченный ИЛИ; 
// ! - НЕ.