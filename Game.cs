using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;



namespace SimpleConsoleGame
{

    /// <summary>
    /// The Game class
    /// </summary>
    internal class Game
    {
        //1 alle velden
        private Player player;
        private KeyboardController keyboardController;
        // we maken een object player is player player :
        //consturctor
        public Game()
        {
            keyboardController = new KeyboardController();
            player = new Player(keyboardController);; 
        }
        // andere methodes

        /// <summary>
        /// The Play method, this starts the game.
        /// </summary>
        ///
        public void Play()
        {
            while (true)
            {
                Update();
            }
        }

        private void Update()
        {
            keyboardController.Update();
            player.Update();
        }
        /// <summary>
        /// Update, gets called continuously while the game is playing.
        /// </summary>

    }

}
