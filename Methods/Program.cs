// Вид 1 НЕ ПРИНИМАЮТ И НЕ ВОЗВРАЩАЮТ
/*
void Method1() // в скобках СЛЕВА АРГУМЕНТОВ НЕТ
// ниже тело метода
{
System.Console.WriteLine("Автор...");
}
// вызов метода ниже
//Method1(); // вызвали метод, задали исполнение
*/
// Вид2 ПРИНИМАЮТБ НО НЕ ВОЗВРАЩАЮТ
/*
void Method2(string msg)
{
//    System.Console.WriteLine(msg);
}

Method2(msg: "Текст сообщения");
void Method21(string msg, int count)
{
    int i = 0;
    while (i<count)
        {
//        System.Console.WriteLine(msg);
        i++;
        }
}
// Можем явно указать, какому аргументу
// какое значение присваивать
//Method21(msg:"Текст", count: 4);
//Method21(count: 4, msg: "Новый Текст");

// Вид3 ЧТО ТО ВОЗВРАЩАЮТ НО НИ ЧЕГО НИ ПРИНЕМАЮТ

int Method3() // Метод
{
    return DateTime.Now.Year;
}
int year = Method3(); // Результат метода
//Console.WriteLine(year); // вывод результата
*/
// Вид4 ПРИНИМАЮТ И ВОЗВРАЩАЮТ ДАННЫЕ


int Method4(int count, string text) // будем строку
// "text" выводить count раз
{
    int i = 0;
    string result =""; // String.Emty правильно обозначили
    while (i<count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "asdf");
System.Console.WriteLine(res);

