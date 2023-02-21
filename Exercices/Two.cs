using Main.Function;

namespace Main.Exercices;

public class Two
{
    
    private static List<int> numbers = new List<int>(){};
    public static void Run()
    {
        var sum = MakeSumWithoutDuplicateNumber();
        Console.WriteLine($"The sum is: {sum}");
    }

    private static int MakeSumWithoutDuplicateNumber()
    {
        int choosenNumber;
        
        do
        {
            choosenNumber = ChooseANumber();
            numbers.Add(choosenNumber);
        } while (numbers.FindAll(x=> x == choosenNumber).Count() < 2);
        
        numbers.Remove(choosenNumber);
        return numbers.Sum();
    }

    private static int ChooseANumber()
    {
        int choosenNumber = 0;
        Console.WriteLine("Choose a positive number: ");
        
        do
        {
            try
            {
                choosenNumber = Convert.ToInt32(Console.ReadLine());
                if(choosenNumber < 0)
                    ColoredConsole.WriteInColor("The number canno't be negative", ConsoleColor.Red);
            }catch(Exception e)
            {
                ColoredConsole.WriteInColor("Please, type a positive number", ConsoleColor.Red);
            }
                
        } while (choosenNumber < 0);

        return choosenNumber;
    } 
}