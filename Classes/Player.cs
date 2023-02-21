namespace Main.classes;

public class Player
{
    private string name;
    private int score;
    private int resultOfTheMatch;
    private static List<String> RockPaperScissors = new List<String>(){"Rock", "Paper", "Scissors"};
    
    public Player(string nameOfThePlayer)
    {
        name = nameOfThePlayer;
        score = 0;
    }
    
    public string Name
    {
        get => name;
        set => name = value;
    }
    
    public int Score
    {
        get => score;
        set => score = value;
    }

    public int ResultOfTheMatch
    {
        get => resultOfTheMatch;
        set => resultOfTheMatch = value;
    }
    
    private static int RandomNumber()
    {
        Random random = new Random();
        return random.Next(0, 3);
    }
    
    public void PlayWithAnotherPlayer(Player player)
    {
        var currentPlayer = RockPaperScissors[RandomNumber()];
        var otherPlayer = RockPaperScissors[RandomNumber()];
        
        if(WinRock(currentPlayer, otherPlayer) == true)
        {
            ResultOfTheMatch++;
            Console.WriteLine($"{name} win the round with {currentPlayer} against {player.name} with {otherPlayer}");
        }
        else if(WinRock(otherPlayer, currentPlayer) == true)
        {
            player.ResultOfTheMatch++;
            Console.WriteLine($"{player.name} win the round with {otherPlayer} against {name} with {currentPlayer}");
        }
        else
        {
            Console.WriteLine($"Equality ! {name} use {currentPlayer} and {player.name} {otherPlayer}");
        }
    }

    private static bool? WinRock(string currentPlayer, string otherPlayer) =>
        currentPlayer == "Rock" && otherPlayer == "Scissors"
        || currentPlayer == "Paper" && otherPlayer == "Paper"
        || currentPlayer == "Scissors" && otherPlayer == "Paper";

}