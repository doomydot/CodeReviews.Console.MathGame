namespace _2_MathGame;

internal class Menu
{
    private GameEngine _engine = new();
    internal void ShowMenu(string name, DateTime date) {
    
        var isGameOver = false;

        do {
            Console.Clear();
            Console.WriteLine($"Hello, {name}. It's {date.DayOfWeek}, let's practice!");
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"""
                               What would you like to play today:
                               V - View Previous Games
                               A - Addition
                               S - Subtraction
                               M - Multiplication
                               D - Division
                               Q - Quit
                               """);
            Console.WriteLine("-------------------------------");
            var gameSelected = Console.ReadLine()!.Trim().ToLower();

            switch (gameSelected) {
                case "v":
                    Helpers.ViewGameList();
                    break;
                case "a":
                    _engine.AdditionGame("Addition Game");
                    break;
                case "s":
                    _engine.SubtractionGame("Subtraction Game");
                    break;
                case "m":
                    _engine.MultiplicationGame("Multiplication Game");
                    break;
                case "d":
                    _engine.DivisionGame("Division Game");
                    break;
                case "q":
                    Console.WriteLine("Bye!");
                    isGameOver = true;
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        
        }while (!isGameOver);
    }
}