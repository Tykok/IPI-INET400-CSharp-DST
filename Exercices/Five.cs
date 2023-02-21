using Main.classes;
using Main.Function;

namespace Main.Exercices;
public class Five
{

    private static List<Player> listOfPlayer = new List<Player>() { };
    
    public static void Run()
    {
        GetAllPlayersName();
        BatllePlayers();
        ShowBoardClassment();
    }
    
    private static void ShowBoardClassment()
    {
        var board = listOfPlayer.OrderByDescending(x => x.Score).ToList();
        Console.WriteLine("Board classment:");
        var first = true;
        foreach (var player in board)
        {
            if(first)
            {
                ColoredConsole.WriteInColor($"🥇{player.Name} : {player.Score}", ConsoleColor.Green); ;
                first = false;
            }
            else
                Console.WriteLine($"{player.Name} : {player.Score}");
        }
    }
    
    private static void BatllePlayers()
    {
        for(int i = 0; i <= 3; i++)
        {
            foreach (var player in listOfPlayer)
            {
                var playerToPlay = listOfPlayer.Where(x => x != player).ToList();
                foreach (var counter in playerToPlay)
                {
                    Console.WriteLine();
                    player.PlayWithAnotherPlayer(counter);
                }
            }

            var winnerOfTheMatch = listOfPlayer.MaxBy(x => x.ResultOfTheMatch);
            winnerOfTheMatch.Score += winnerOfTheMatch.ResultOfTheMatch * 2;
            Console.WriteLine("Winner of the match: " + winnerOfTheMatch.Name + " with " + winnerOfTheMatch.ResultOfTheMatch + " points");
            
            var loserOfTheMatch = listOfPlayer.FindAll(x => x != winnerOfTheMatch);
            loserOfTheMatch.ForEach(x => x.Score += x.ResultOfTheMatch);
        }
    }
    
    private static void GetAllPlayersName()
    {
        ColoredConsole.WriteInColor("Press Enter to validate your input, and press Escape to stop the program when you are done.", ConsoleColor.Green);
        Console.WriteLine("Enter a player name:");
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
                listOfPlayer.Add(new Player(result));
                result = "";
                Console.WriteLine("Enter a player name");
            }
            else if(keyName == ConsoleKey.Backspace)
            {
                // Console.Write("\b");
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
}