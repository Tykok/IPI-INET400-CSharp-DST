using Main.Function;

namespace Main;
using Exercices;

class Program
{
    static void Main(string[] args)
    {
        /*
        WriteExercices(1);
        One.Run();
        Console.WriteLine();
        
        WriteExercices(2);
        Two.Run();
        Console.WriteLine();
        
        
        WriteExercices(4);
        Four.Run();
        Console.WriteLine();
        
        WriteExercices(5);
        Five.Run();
        */
        
        
        WriteExercices(3);
        Three.Run();
        Console.WriteLine();
        
    }

    private static void WriteExercices(int exercices)
    {
        ColoredConsole.BackgroundInColor("-------------------------------------------------", ConsoleColor.DarkBlue);
        Console.WriteLine($"Exercices: {exercices}");
        Console.WriteLine();
    }
}

