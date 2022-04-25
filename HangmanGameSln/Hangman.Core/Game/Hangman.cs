using System;
using HangmanRenderer.Renderer;

namespace Hangman.Core.Game
{
    public class HangmanGame
    {
        private GallowsRenderer _renderer;
        private string[] _GuessProgress;
        private int _NumberOfLives;
        private string _guessTipDisplay;
        string[] ListOfWords;
        Random random;
        string GuessingWords;
        public HangmanGame()
        {
            _renderer = new GallowsRenderer();
            random = new Random();
            ListOfWords = new string[] { "science", "rock", "water", "soil", "data", "capture", "quality", "report", "analyse", "conduct", "geology", "earth", "field", "lab", "principles", "manage", "protect", "conserve", "integration", "resource" };
            var index = random.Next(0, ListOfWords.Length);
            GuessingWords = ListOfWords[index];
        }

        public void Run()
        {
            _NumberOfLives = 6;
            _renderer.Render(5, 5, 6);
            for (int i = 0; i < GuessingWords.Length; i++)
            {
                Console.SetCursorPosition(0, 19);
                _guessTipDisplay += "-";
            }
            Console.SetCursorPosition(0, 14);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Your current guess: ");
            Console.SetCursorPosition(0, 16);
            Console.WriteLine(_guessTipDisplay);
            //Console.WriteLine("--------------");
            

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("What is your next guess: ");
            Console.SetCursorPosition(25, 17);
            var nextGuess = Console.ReadLine();


            char[] guess = Console.ReadLine().ToCharArray();
            Console.SetCursorPosition(0, 17);
            

            

            char[] Guess = GuessingWords.ToCharArray();
           
            
            while (_NumberOfLives > 0)
            {
                _renderer.Render(5, 5, _NumberOfLives);
                Console.SetCursorPosition(0, 21);
                char[] guesser = Console.ReadLine().ToCharArray();

                //char[] GuessProgressArray = _GuessProgress[].ToCharArray();

                bool correct = false;

                for (int i = 0; i < guess.Length; i++) ;
                for (int j = 0; j < guesser.Length; j++)
                {
                    //if (guess[i])==guesser
                    //GuessProgressArray[i] = guess[i];
                    correct = true;

                   // _GuessProgress = new string(GuessProgressArray);
                    Console.SetCursorPosition(0, 21);

                    Console.WriteLine(_GuessProgress);

                    if (!correct)
                    {
                        _NumberOfLives--;
                        _renderer.Render(5, 5, _NumberOfLives);
                    }


                    Console.SetCursorPosition(0, 21);

                    if (_NumberOfLives == 0)
                    {
                        Console.WriteLine("you lost");
                    }
                    else
                    {
                        Console.WriteLine("you won with {_NumberOfLives} left.");
                    }

                    }


                }
            }


        }
    }

