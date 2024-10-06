namespace _2_MathGame.Models;


internal record Game(DateTime Date, GameType Type, int Score );

internal enum GameType
{
    Addition,
    Subtraction,
    Multiplication,
    Division
}