// 2 var
Worker worker = new Worker();

Console.Write("Введите день: ");
worker.Day = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите месяц: ");
worker.Month = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите год: ");
worker.Year = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите ФИО: ");
worker.Fio = Console.ReadLine();
Console.Write("Введите дату поступления (в формате дд.мм.гггг): ");
worker.ReceiptDate = DateOnly.Parse(Console.ReadLine()!);

Console.WriteLine($"{worker.Fio} | {worker.GetCountYearsWork()}");



public class MyClass
{
    private int day;
    private int month;
    private int year;

    public MyClass(int day, int month, int year)
    {
        Day = day;
        Month = month;
        Year = year;
    }

    public MyClass()
    {
        Day = 0;
        Month = 0;
        Year = 0;
    }

    public int Day
    {
        get { return day; }
        set
        {
            if (value >= 0) day = value;
            else day = 0;
        }
    }
    public int Month
    {
        get { return month; }
        set
        {
            if (value >= 0) month = value;
            else month = 0;
        }
    }
    public int Year
    {
        get { return year; }
        set
        {
            if (value >= 0) year = value;
            else year = 0;
        }
    }

    public void AddYear()
    {
        Year += 1;
    }

    public void SubTwoDays()
    {
        DateTime date = new DateTime(Year, Month, Day)
            .Subtract(new TimeSpan(2, 0, 0, 0));
        Day = date.Day;
        Month = date.Month;
        Year = date.Year;
    }
}

public class Worker : MyClass
{
    public string? Fio { get; set; }
    public DateOnly ReceiptDate { get; set; }


    public Worker(int day, int month, int year, DateOnly receiptDate) : base(day, month, year)
    {
        Day = day;
        Month = month;
        Year = year;
        ReceiptDate = receiptDate;
    }

    public Worker()
    {
        Day = 0;
        Month = 0;
        Year = 0;
        ReceiptDate = new DateOnly();
    }


    public int GetCountYearsWork()
    {
        return ReceiptDate.Year - Year;
    }

}