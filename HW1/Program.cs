// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите день недели:");
int i = Convert.ToInt32(Console.ReadLine());
string str = i switch
{
    1 => "Понедельник",
    2 => "Вторник",
    3 => "Среда",
    4 => "Четверг",
    5 => "Пятница",
    6 => "Суббота",
    7 => "Воскресенье",
    _ => "Введите день недели с 1 по 7"
};
Console.WriteLine($"День недели \"{str}\"");
Console.ReadKey();
