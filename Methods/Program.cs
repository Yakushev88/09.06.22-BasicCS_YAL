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

/*
string Method4(int count, string text) // будем строку
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
*/
/*
string Method4(int count, string text) // будем строку
// "text" выводить count раз
{

    string result =""; // String.Emty правильно обозначили
    for (int i=0; i<count; i++ ) // Строка инициализации
    {
        result = result + text;
    }
    return result;
}
string res = Method4(5, "asdf");
System.Console.WriteLine(res);
*/
/*
// Вывод таблицы умножения на экран

for (int i=2; i<=10; i++ ) // Строка инициализации
{
    for (int j=2; j <=10; j++) // Счетчики внешний и внутренний должны иметь разные названия
   {
        System.Console.WriteLine($"{i}x{j}={i*j}");
   } 
   System.Console.WriteLine();    
}
*/
// Работа с текстом
// Дан текстю В тексте нужно все пробелы заменить на 
// нижнее подчеркивание. Маленькие буквы "k" заменить
// на большие К, а большие С заменить на меленькие с.
// Ясна ли задача?
/*
string text = "-Я думаю, - сказал князь, улыбаясь, -что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прксского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю? ";
// string s = "qwerty"
//             012// Присваиваем буквам индексы
// s[3] //
// Возвращаться будет строка, поэтому метод условно 4-ый
string Replace(string text, char oldValue, char newValue)
{
   string result = String.Empty; // инициализация пустой строки
   int length = text.Length; // обращение к свойству,показывающему количество символов в строке
   for (int i=0; i<length; i++) // пробегаем от нулевого символа до последнего по всей длинне текста
   {
    if (text[i]==oldValue) result = result + $"{newValue}";
    else result = result + $"{text[i]}";
   }
   return result; 
}
string newText = Replace(text, ' ', '|');

System.Console.WriteLine(newText);
System.Console.WriteLine();
newText = Replace(newText, 'к', 'К');
System.Console.WriteLine(newText);
System.Console.WriteLine();
newText = Replace(newText, 'С', 'с');
System.Console.WriteLine(newText);
*/

// Сортировка массива
int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};
// далее написать подпрограмму, 
// которая выводит массив на экран
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i=0; i< count; i++) // пробегаем по всем элементам массива 
    {
        System.Console.Write($"{array[i]}");
    }
    System.Console.WriteLine();
}

void SelectionSort(int[] array)// Программа сортировки массива
{
    for (int i=0; i < array.Length-1; i++)
    {
        int minPosition = i; //Запоминаем позицию рабочего элемента
        //  с которой будем производить действия в дальнейшем
        for (int j=i+1; j < array.Length; j++ )// Часть кодаб жля поиска максимальног элемента
        // 3-ри строки ниже
        {
            if (array[j]<array[minPosition]) minPosition= j;
        }


        int temporary = array[i]; // временный элемент
        array[i]=array[minPosition];
        array[minPosition]= temporary;

    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
