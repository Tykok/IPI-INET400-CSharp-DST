namespace Main;
using Exercices;

class Program
{
    static void Main(string[] args)
    {
        WriteExercices(1);
        One.Run();
        
        WriteExercices(2);
        Two.Run();
        
        WriteExercices(3);
        Three.Run();
        
        WriteExercices(4);
        Four.Run();
        
        WriteExercices(5);
        Five.Run();
    }

    private static void WriteExercices(int exercices)
    {
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine($"Exercices: {exercices}");
        Console.WriteLine("-------------------------------------------------");
    }
}

