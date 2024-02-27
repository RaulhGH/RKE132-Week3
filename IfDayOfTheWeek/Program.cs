
int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);

Console.WriteLine(weekDay);

if (weekDay == 0)
{
    Console.WriteLine("Pühap");
}

else if (weekDay == 1)
{
    Console.WriteLine("e");
}

else if (weekDay == 2)
{
    Console.WriteLine("t");
}

else if (weekDay == 3)
{
    Console.WriteLine("k");
}

else if (weekDay == 4)
{
    Console.WriteLine("n");
}

else if (weekDay == 5)
{
    Console.WriteLine("r");
}

else
{
    Console.WriteLine("l");
}

