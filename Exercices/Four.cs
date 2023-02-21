using System.Text.RegularExpressions;
using Main.Function;

namespace Main.Exercices;

public class Four
{
    
    private static List<String> listOfInput = new List<string>(){};
    
    public static void Run()
    {
        ReadLinesWithEscape();
        ShowAllInputReverse();
    }

    private static void ReadLinesWithEscape()
    {
        ColoredConsole.WriteInColor("Press Enter to validate your input, and press Escape to stop the program when you are done.", ConsoleColor.Green);
        Console.WriteLine("Enter a string:");
        var result = "";
        do
        {
            var key = Console.ReadKey(true);
            var character = key.KeyChar;
            var keyName = key.Key;
            
            if(keyName == ConsoleKey.Escape)
                break;
            
            if(keyName == ConsoleKey.Enter)
            {
                Console.WriteLine();
                listOfInput.Add(result);
                result = "";
                Console.WriteLine("Enter a string");
            }
            else if(keyName == ConsoleKey.Backspace)
            {
                Console.Write("\b");
                // result = result.Substring(0,result.Length - 1);
                Console.WriteLine("Sorry, the backspace canno't be implemented");
            } 
            else
            {
                Console.Write(character);
                result += character;
            }

        } while (true);
    }
    
    private static void ShowAllInputReverse()
    {
        for(int i = listOfInput.Count -1 ; i >= 0; i--)
        {
            var input = listOfInput[i];
            Console.WriteLine(ApplyRulesOnInput(input));
        }
    }

    private static string ApplyRulesOnInput(string input)
    {
        input = input.Replace("_", "");
        if (input.Length % 2 == 1)
            input = input.Replace("e", "!");

        input = Regex.Replace(input, @"[0-9]", "_");
        return input;
    }
}