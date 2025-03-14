using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_O_GameNew.Players
{
    internal class Player
    {
        /// <summary>
        /// Custom setting for player configurtion
        /// </summary>
        /// <param name="playerId">There have to be Id 1 or 2 for playerOne and playerTwo</param>
        /// <param name="playerNick">Set your custom nickname for player. If empty there will be "default name" as nick for Id player.</param>
        /// <param name="marker">Set your custom marker for player. If empty there will be classic "O or X" depend on Id player.</param>
        /// <exception cref="ArgumentException"></exception>
        public class Players
        { 
            private int PlayerId { get; set; }
            private string? PlayerNick { get; set; }
            public string? Marker { get; set; }

            public Players(int playerId, string? playerNick, string? marker)
            {
                PlayerNick = string.IsNullOrWhiteSpace(playerNick) ? "DOMYŚLNA NAZWA" : playerNick;

                if (playerId != 1 && playerId != 2)
                    throw new ArgumentException("playerId musi być 1 lub 2!");

                PlayerId = playerId;

                Marker = marker ?? (playerId == 1 ? "O" : "X");
            }
        }

    }
}
