using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using X_O_GameNew.Consts;
using X_O_GameNew.Interface;
using X_O_GameNew.Players;


namespace X_O_GameNew.Data
{
    internal class SettingsData
    {
        internal static readonly MenuFields.Menu OptionMenuPl = new MenuFields.Menu(MenuTextFields.setCustomPLayerName, MenuTextFields.setCustomPlayerMarker, MenuTextFields.goBack);
        internal static readonly MenuFields.Menu CustomChangeMenuPL = new MenuFields.Menu("1.\t" + DefaultPlayerProporties.defaultName1, "2.\t" + DefaultPlayerProporties.defaultName2, MenuTextFields.goBack);
        public static List<Players.Players.Player> PlayersData()
        {
            List<Players.Players.Player> players = new List<Players.Players.Player>
            {
                new Players.Players.Player(DefaultPlayerProporties.playerId1,"121dddddd",DefaultPlayerProporties.defaultMarker1),
                new Players.Players.Player(DefaultPlayerProporties.playerId2,DefaultPlayerProporties.defaultName2,DefaultPlayerProporties.defaultMarker2),
            };
            return players;
        }
    }
}


