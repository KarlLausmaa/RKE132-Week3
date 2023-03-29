using System.ComponentModel.Design;

int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);

if (weekDay == 0)
{
    Console.WriteLine("Sunday");
} else if (weekDay == 1)
{
    Console.WriteLine("Monday");
}
else if (weekDay == 2)
{
    Console.WriteLine("Tuestday");
}
else if (weekDay == 3)
{
    Console.WriteLine("Wednesday");
}
else if (weekDay == 4)
{
    Console.WriteLine("Thursday");
}
else if (weekDay == 5)
{
    Console.WriteLine("Friday");
}
else 
{
    Console.WriteLine("Saturday");
}

Console.WriteLine("Have a nice day!");