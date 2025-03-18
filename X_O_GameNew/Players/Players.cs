using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_O_GameNew.Players
{
    internal class Players
    {
        /// <summary>
        /// Custom setting for player configurtion
        /// </summary>
        /// <param name="playerId">There have to be Id 1 or 2 for playerOne and playerTwo</param>
        /// <param name="playerNick">Set your custom nickname for player. If empty there will be "default name" as nick for Id player.</param>
        /// <param name="marker">Set your custom marker for player. If empty there will be classic "O or X" depend on Id player.</param>
        /// <exception cref="ArgumentException"></exception>
        public class Player
        {
            public int PlayerId { get; }
            public string PlayerNick { get; set; }
            public string PlayerMarker { get; set; }
            public bool HasATurn { get; set; }

            public Player(int playerId, string playerNick, string marker)
            {

                if (playerId != 1 && playerId != 2)
                    throw new ArgumentException("playerId musi mieć wartość 1 lub 2 !");

                PlayerId = playerId;
                PlayerMarker = marker;
                PlayerNick = playerNick;

            }
        }
    }
}
