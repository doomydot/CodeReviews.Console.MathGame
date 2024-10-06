using _2_MathGame.Models;

namespace _2_MathGame;

public class GameEngine
{
    internal void AdditionGame(string message) {
        var rand = new Random();
        var score = 0;
        int firstNum;
        int secondNum;

        for (var i = 0; i < 5; i++) {
            Console.Clear();
            Console.WriteLine(message);
            
            firstNum = rand.Next(1, 9);
            secondNum = rand.Next(1, 9);

            Console.WriteLine($"{firstNum} + {secondNum} = ?");
            var result = Helpers.ReadResult()!;
            
            
            

            if (int.Parse(result) == firstNum + secondNum) {
                score++;
                Console.WriteLine("Correct, press any key to continue.");
            }
            else {
                Console.WriteLine("Incorrect, press any key to continue.");
            }

            Console.ReadLine();


            if (i != 4) continue;
            Console.WriteLine($"Game over. Your final score is {score}. Press any key to return to menu.");
            Console.ReadLine();
        }

    
        Helpers.AddToHistory(score, GameType.Addition);
    }

    internal void SubtractionGame(string message) {
        var rand = new Random();
        var score = 0;
        int firstNum;
        int secondNum;

        for (var i = 0; i < 5; i++) {
            Console.Clear();
            Console.WriteLine(message);
            
            firstNum = rand.Next(1, 9);
            secondNum = rand.Next(1, 9);

            Console.WriteLine($"{firstNum} - {secondNum} = ?");
            var result = Helpers.ReadResult()!;

            if (int.Parse(result) == firstNum - secondNum) {
                score++;
                Console.WriteLine("Correct, press any key to continue.");
                Console.ReadLine();
            }
            else {
                Console.WriteLine("Incorrect, press any key to continue.");
                Console.ReadLine();
            }


            if (i != 4) continue;
            Console.WriteLine($"Game over. Your final score is {score}. Press any key to return to menu.");
            Console.ReadLine();
        }
        Helpers.AddToHistory(score, GameType.Subtraction);
    }

    internal void MultiplicationGame(string message) {
        var rand = new Random();
        var score = 0;
        int firstNum;
        int secondNum;

        for (var i = 0; i < 5; i++) {
            Console.Clear();
            Console.WriteLine(message);
            
            firstNum = rand.Next(1, 9);
            secondNum = rand.Next(1, 9);

            Console.WriteLine($"{firstNum} * {secondNum} = ?");
            var result = Helpers.ReadResult()!;

            if (int.Parse(result) == firstNum * secondNum) {
                score++;
                Console.WriteLine("Correct, press any key to continue.");
                Console.ReadLine();
            }
            else {
                Console.WriteLine("Incorrect, press any key to continue.");
                Console.ReadLine();
            }


            if (i != 4) continue;
            Console.WriteLine($"Game over. Your final score is {score}. Press any key to return to menu.");
            Console.ReadLine();
        }
        Helpers.AddToHistory(score, GameType.Multiplication);
    }

    internal void DivisionGame(string message) {
        var score = 0;
        
        for (var i = 0; i < 5; i++) {
            Console.Clear();
            Console.WriteLine(message);
            var numbers = GetDivisionNumbers();
            
            
            Console.WriteLine($"{numbers.First} / {numbers.Second}");
            var result = Helpers.ReadResult()!;
            
            if (int.Parse(result) == numbers.First / numbers.Second) {
                score++;
                Console.WriteLine("Correct, press any key to continue.");
                Console.ReadLine();
            }
            else {
                Console.WriteLine("Incorrect, press any key to continue.");
                Console.ReadLine();
            }

            if (i != 4) continue;
            Console.WriteLine($"Game over. Your final score is {score}. Press any key to return to menu.");
            Console.ReadLine();

        }
        
        Helpers.AddToHistory(score, GameType.Division);
    }

    (int First, int Second) GetDivisionNumbers() {
        var rand = new Random();
        var firstNumber = rand.Next(1, 99);
        var secondNumber = rand.Next(1, 99);
        
        while (firstNumber % secondNumber != 0) {
            firstNumber = rand.Next(1, 99);
            secondNumber = rand.Next(1, 99);
        }
        
        (int First, int Second) result;
        result.First = firstNumber;
        result.Second = secondNumber;

        return result;
    }
}