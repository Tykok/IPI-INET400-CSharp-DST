using Main.Function;

namespace Main.Exercices;

public class Three
{
    public static void Run()
    {
        var thickness = ChooseThickness();
        var length = ChooseLength();
        Console.WriteLine();
        MakeACube(thickness, length);
    }

    private static int ChooseThickness()
    {
        int thickness = 0;

        Console.WriteLine("Choose the thickness of the cube: ");
        do
        {
            try
            {
                thickness = int.Parse(Console.ReadLine());
                if (thickness < 0)
                    ColoredConsole.WriteInColor("The thickness canno't be negative", ConsoleColor.Red);
            }
            catch (Exception e)
            {
                ColoredConsole.WriteInColor("Please, choose a positive number", ConsoleColor.Red);
            }

        }while (thickness < 0);
        return thickness;
    }
    
    private static int ChooseLength()
    {
        int length = 0;

        Console.WriteLine("Choose the length of the cube: ");
        do
        {
            try
            {
                length = int.Parse(Console.ReadLine());
                if (length < 0)
                    ColoredConsole.WriteInColor("The length canno't be negative", ConsoleColor.Red);
            }
            catch (Exception e)
            {
                ColoredConsole.WriteInColor("Please, choose a positive number", ConsoleColor.Red);
            }

        }while (length < 0);
        return length;
    }
    
    
    private static void MakeExtremity(int thickness, int lenght)
    {
        for (int i = 0; i < thickness; i++)
        {
            for (int j = 0; j < lenght; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    
    private static void MakeACube(int thickness, int lenght)
    {
        MakeExtremity(thickness, lenght);
        
        // Make the body of the cube
        for(int i = thickness; i < lenght; i++)
        {
            for (int j = 0; j < lenght; j++)
            {
                if(j < thickness || j >= lenght - thickness)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
        
        MakeExtremity(thickness, lenght);
    }
}