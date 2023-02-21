namespace Main.Function;

public class ColoredConsole
{
    public static void WriteInColor(string text, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(text);
        Console.ResetColor();
    }
    
    public static void BackgroundInColor(string text, ConsoleColor color)
    {
        Console.BackgroundColor = color;
        Console.WriteLine(text);
        Console.ResetColor();
    }
    
}