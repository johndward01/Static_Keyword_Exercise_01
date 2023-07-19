namespace Static_Keyword_Exercise;

public class Person
{
    public static int count;
    public string name;

    public Person()
    {
        count++;
    }

    public static void PrintCount()
    {
        Console.WriteLine($"People Count: {count}");
    }

}
