
int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);

switch(weekDay)//väärtus mida kontrollitakse
{
    case 0: //case 0:  == if(weekDay == 0)
        Console.WriteLine("Pühap");
        break;

    case 1: //case 0:  == if(weekDay == 0)
        Console.WriteLine("Esmasp");
        break;

    case 2: //case 0:  == if(weekDay == 0)
        Console.WriteLine("teis");
        break;

    case 3: //case 0:  == if(weekDay == 0)
        Console.WriteLine("kolmap");
        break;

    case 4: //case 0:  == if(weekDay == 0)
        Console.WriteLine("neljap");
        break;

    case 5: //case 0:  == if(weekDay == 0)
        Console.WriteLine("reede");
        break;

    case 6: //case 0:  == if(weekDay == 0)
        Console.WriteLine("laup");
        break;
    default:
        Console.WriteLine("Calender on katki!!");
}
Console.WriteLine("Have nice day!");