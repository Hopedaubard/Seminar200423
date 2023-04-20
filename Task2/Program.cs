// Задача №3. Напишите программу, которая будет 
// выдавать название дня недели по заданному номеру.

// 3 -> Среда 
// 5 -> Пятница

Console.WriteLine("Введите число от 1 до 7: ");
int dayNum = int.Parse(Console.ReadLine());
if (dayNum == 1)
{
    Console.WriteLine("Понедельник");
}
else if (dayNum == 2)
{
    Console.WriteLine("Вторник");
    }
else if (dayNum == 3)
{
Console.WriteLine("Среда");
    }
else if (dayNum == 4)
{
    Console.WriteLine("четверг");
    }
else if (dayNum == 5)
{
Console.WriteLine("Пятница");
    }
else if (dayNum == 6)
{
Console.WriteLine("Суббота");
    }
else if (dayNum == 7)
{ 
Console.WriteLine("Воскресение");
    }