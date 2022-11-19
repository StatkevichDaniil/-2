// Задача №10
Console.WriteLine("Введите число");
string Number = Console.ReadLine();
if(Number.Length !=3){
    Console.WriteLine ("Введено неверное число!");
}
else {
    Console.WriteLine($"Число без первой и третьей цифры имеет вид: {Number[1]}");
}
// Задача 13
Console.WriteLine("Введите число");
string Numbers = Console.ReadLine();
if(Numbers.Length <3 || Numbers.Length >5){
    Console.WriteLine ("Введено неверное число!");
}
else {
    Console.WriteLine($"третьей цифрой является: {Numbers[2]}");
}

// задача 15
int DayNumbers = ReadInt("Введите число от 1 до 7");
Console.WriteLine(WorkHoliday(DayNumbers));
int ReadInt(string message)
{
    return Convert.ToInt32(Console.ReadLine());
}
string WorkHoliday (int a)
{
    if (a>0 && a<8)
    {
        if (a == 7 || a == 6)
        {
            Console.Write("Под цифрой "+ a +" - Выходной");
        }
        else 
    {
     Console.Write("Под цифрой "+ a +" - Рабочий");   
    }
} 
else
{
    Console.Write("Вы ввели число не в пределах от 1 до 7, поэтому невозможно опреелить");
}
return "день.";
}
