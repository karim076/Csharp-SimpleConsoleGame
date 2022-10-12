using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConsoleGame
{
    internal class KeyboardController
    {
        public ConsoleKey lastPressed;

        public void Update()
        {
            // Get the last key pressed from the Console (if one is available)
            if (Console.KeyAvailable)
            {
                lastPressed = Console.ReadKey(true).Key;
            }
        }

        public ConsoleKey GetLastPressed()
        {
            ConsoleKey tempKey = lastPressed;
            lastPressed = 0;
            return tempKey;
        }
    }
}
