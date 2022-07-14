/*
void FillArray(int[] collection)
// void - метод который не возвращает значения
// в коде при этом не нужно использовать return
{
    int length = collection.Length;
    int index = 0;
    while (index<length)
    {
        collection[index] = new Random() .Next(1, 10);
        // index=index+1;
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length; // количество элементов массива равно длинне массива
    int position = 0;
    while (position < count)
    {
        System.Console.WriteLine(col[position]);
        position++;
    }
}
// задаем массив с 10-ю элементами по умолчанию
// создай новый массив в котором будет 10 элементов
// по умолчанию наполнен нулями.
int[] array = new int[10]; 

FillArray(array); // метод заполнения массива
PrintArray(array); // метод вывода на экран
*/

// Задача поиск позиции нужного элемента в массиве

void FillArray(int[] collection)
// void - метод который не возвращает значения
// в коде при этом не нужно использовать return
{
    int length = collection.Length;
    int index = 0;
    while (index<length)
    {
        collection[index] = new Random() .Next(1, 10);
        // index=index+1;
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length; // количество элементов массива равно длинне массива
    int position = 0;
    while (position < count)
    {
        System.Console.WriteLine(col[position]);
        position++;
    }
}
int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;
    while (index<count)
    {
        if(collection[index] == find)
        {
            position = index;// для второго вхождения ивывода индекса второго зпдпнного элемента в случайном массиве
            break;
        }
        index++;
    }
    return position;
}
// задаем массив с 10-ю элементами по умолчанию
// создай новый массив в котором будет 10 элементов
// по умолчанию наполнен нулями.
int[] array = new int[10]; 

FillArray(array); // метод заполнения массива
PrintArray(array); // метод вывода на экран
System.Console.WriteLine();

int pos  = IndexOf(array, 4);
System.Console.WriteLine(pos);
