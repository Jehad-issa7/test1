public class Program
{
    private static void Main()
    {
        Console.WriteLine(GetGreeting());
    }
    public static string GetGreeting(String name = "World")
    {

        return $"Hello, {name}!";
        //   if (string.IsNullOrWhiteSpace(input))
        //     return "Hello,world";
    }
    public static string GetGreeting(string name, string language)
    {
        return language.ToLower() switch
        {
            "spanish" => $"Hola, {name}!",
            "french" => $"Bonjour, {name}!",
            _ => GetGreeting(name)
        };
    }
}