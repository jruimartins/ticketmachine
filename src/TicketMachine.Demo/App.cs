using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using TicketMachine.Core;

namespace TicketMachine.Demo
{
    class App
    {

        private readonly IMachine _ticketMachine;

        public App(IMachine ticketMachine)
        {
            _ticketMachine = ticketMachine;
        }

        public void Run()
        {
            var userInput = "";

            while (true)
            {
                Console.Out.WriteLine($"SEARCH STATION:{userInput.ToUpperInvariant()}");
                var userChar = Console.ReadKey(true).KeyChar;

                if (userChar == '\u001b')
                {
                    userInput = "";
                }
                else if (IsValidChar(userChar))
                {
                    userInput += userChar;
                    var suggestions = _ticketMachine.FindStation(userInput);

                    Console.Out.WriteLine($"-----STATIONS:-----{Environment.NewLine}{suggestions.StationsToString()}{Environment.NewLine}");
                    Console.Out.WriteLine($"-----NEXT LETTERS:-----{Environment.NewLine}{suggestions.NextLettersToString()}{Environment.NewLine}");
                    Console.Out.WriteLine($"PRESS 'ESC' TO CLEAR SEARCH AND START AGAIN");
                }
            }
        }


        private static bool IsValidChar(char userInputChar)
        {
            return Regex.IsMatch(userInputChar.ToString(), @"[a-zA-Z]");
        }
    }
}
