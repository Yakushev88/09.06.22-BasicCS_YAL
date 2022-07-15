// Задача №19 
// Проверить истинность утверждения
// (C# (!X||Y)==!X&!Y))
//!(X || Y)==!X and !Y

int N=567;
System.Console.WriteLine($"N={N}");
bool x,y,f1,f2;
x=true;
y=true;
f1=!(x||y);
f2=!x&&!y;

System.Console.WriteLine($"{x} {y} {f1} {f2}");