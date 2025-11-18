public class Program
{
    private static void Main()
    {

    }
    const string EnglishGreeting = "Hello";

    public static string GetGreeting()
    {
        string input = "";
        if (string.IsNullOrWhiteSpace(input))
            return "Hello,world";

        return EnglishGreeting + input + "!";
    }
}
