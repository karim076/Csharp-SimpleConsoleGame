using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConsoleGame
{
    internal class Player
    {
        public int top = 10;
        public int left = 40;
        private KeyboardController KeyboardController;
        public Player(KeyboardController keyboardController)
        {
            top = 10;
            left = 40;

            this.KeyboardController = keyboardController;
        }
        public void Update()
        {
         
            ConsoleKey lastPressed = KeyboardController.GetLastPressed();
            // Handle keypress
            // Gebruik lastPressed, en probeer dan de character in de juiste richting te verplaatsen.
            if (lastPressed == ConsoleKey.RightArrow)
            {
                TryMove(0, 1);

            }
            else if (lastPressed == ConsoleKey.LeftArrow)
            {
                TryMove(0, -1);
            }
            else if (lastPressed == ConsoleKey.UpArrow)
            {
                TryMove(-1, 0);
            }
            else if (lastPressed == ConsoleKey.DownArrow)
            {
                TryMove(1, 0);
            }


            // Reset keypress
            lastPressed = 0;
        }

        public bool CanMove(int deltaTop, int deltaLeft)
        {

            if (top + deltaTop < 0 || top + deltaTop > 24)
            {
                return false;
            }
            if (left + deltaLeft < 0 || left + deltaLeft > 79)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Moves the character by the specified params.
        /// </summary>
        /// <param name="deltaTop"></param>
        /// <param name="deltaLeft"></param>
        public void Move(int deltaTop, int deltaLeft)
        {
            // Clear current position
            Console.SetCursorPosition(left, top);
            Console.Write(" ");

            top += deltaTop;
            left += deltaLeft;

            // Draw new position
            Console.SetCursorPosition(left, top);
            Console.Write("@");
        }

        /// <summary>
        /// Tries to move the charachter by the specified params. 
        /// </summary>
        /// <param name="deltaTop"></param>
        /// <param name="deltaLeft"></param>
        /// <returns>
        /// A bool that indicates wether the character has been succesfully moved.
        /// </returns>
        public bool TryMove(int deltaTop, int deltaLeft)
        {
            if (CanMove(deltaTop, deltaLeft))
            {
                Move(deltaTop, deltaLeft);
                return true;
            }
            return false;
        }
    }
}
