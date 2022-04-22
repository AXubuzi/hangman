using System;
using HangmanRenderer.Renderer;

namespace Hangman.Core.Game
{
    string[] Guessingwords = { "water, science, rock, soil, data" };
    public class HangmanGame
    {
        private GallowsRenderer _renderer;
        private string [] _Guessingwords;
        private int _NumberOfLives;

        public HangmanGame()
        {
            _renderer = new GallowsRenderer();
        }

        public void Run()
        {
            _renderer.Render(5, 5, 6);

            Console.SetCursorPosition(0, 13);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Your current guess: ");
            Console.WriteLine("--------------");
            Console.SetCursorPosition(0, 15);

            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("What is your next guess: ");
            var nextGuess = Console.ReadLine();
        }

    }
}
