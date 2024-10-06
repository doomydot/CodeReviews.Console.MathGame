using _2_MathGame.Models;

namespace _2_MathGame;

internal class Helpers
{
    internal static List<Game> games = [];
    
    internal static void ViewGameList() {
        /*
        var gamesToPrint = games
            .Where(g => g.Date >= DateTime.Now.AddDays(-7) && g.Score > 3)
            .OrderByDescending(x => x.Score);
        */
        
        Console.Clear();
        Console.WriteLine("Game History");
        Console.WriteLine("-----------------------");
        foreach (var game in games) {
            Console.WriteLine($"{game.Date} - {game.Type} - Score: {game.Score}");
        }
        Console.WriteLine("-----------------------");
        Console.WriteLine("Press any key to return to menu.");
        Console.ReadLine();
    }
    
    internal static void AddToHistory(int score, GameType gameType) {
        games.Add(new Game(DateTime.Now, gameType, score));
    }

    internal static string? GetName() {
        Console.WriteLine("Please type your name:");
        Console.Write("> ");
        var name = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(name)) {
            Console.WriteLine("Name can't be empty.");
            Console.Write("> ");
            name = Console.ReadLine();
        }

        return name;
    }

    public static string? ReadResult() {
        Console.Write("> ");
        var result = Console.ReadLine();
        
        while(string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
        {
            Console.WriteLine("Your answer needs to be an integer.");
            Console.Write("> ");
            result = Console.ReadLine();
        }

        return result;
    }
}