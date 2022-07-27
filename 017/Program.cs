// Дано число обозначающее день недели. 
//Выяснить является номер дня недели выходным
System.Console.WriteLine("Enter the number of week: ");
int numbersDoF= Convert.ToInt32(Console.ReadLine());
string[] weekDays = new string[] {"Monday" , "Tuesday" , "Wednesday" , "Thurstday" ,"Friday" , "Saturday" ," Sunday" ,};
if (numbersDoF==6 ^ numbersDoF==7)
{
    System.Console.WriteLine($"This weekend days is {weekDays[numbersDoF-1]}");
}
else
{
    System.Console.WriteLine($"This weekday is  {weekDays[numbersDoF-1]}");
}

