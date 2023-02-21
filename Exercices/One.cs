using Main.Function;

namespace Main.Exercices;

public class One
{
    
    private static List<String> Days = new List<String>()
    {
        "Lundi",
        "Mardi",
        "Mercredi",
        "Jeudi",
        "Vendredi",
        "Samedi",
        "Dimanche"
    };
    
    public static void Run()
    {
        var choosenDay = ChooseADay();
        var choosenWaitingTime = ChooseWaitingTime();
        var indexOfDay = Days.FindIndex(x => x == choosenDay);

        string finalDay = "";
        // Increment in day until choosenWaintingTime is reached
        for (int i = 0; i < choosenWaitingTime; i++)
        {
            // Get the index of the choosen day

            indexOfDay++;
            if (indexOfDay >= Days.Count)
                indexOfDay = 0;

            finalDay = Days[indexOfDay];
        }
        
        ColoredConsole.WriteInColor($"Since {choosenDay}, {choosenWaitingTime} and now we are {finalDay}", ConsoleColor.Green);
    }
    
    private static string ChooseADay()
    {
        string choosenDay = "";
        Console.WriteLine("Choose a day (FR): ");
        
        do
        {
            choosenDay = Console.ReadLine();
            if(!Days.Exists(x => x == choosenDay))
                ColoredConsole.WriteInColor("Invalid day, try again", ConsoleColor.Red);
        } while (!Days.Exists(x => x == choosenDay));

        return choosenDay;
    }
    
    private static int ChooseWaitingTime()
    {
        int waitingTime = 0;
        Console.WriteLine("Choose a waiting time (in day): ");
        
        do
        {
            try
            {
                waitingTime = Convert.ToInt32(Console.ReadLine());
                if(waitingTime < 0)
                    ColoredConsole.WriteInColor("Waiting time canno't be negative", ConsoleColor.Red);
            }catch(Exception e)
            {
                ColoredConsole.WriteInColor("Please, type a positive number", ConsoleColor.Red);
            }
                
        } while (waitingTime < 0);

        return waitingTime;
    } 
}