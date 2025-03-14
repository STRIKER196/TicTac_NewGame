using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X_O_GameNew.Consts;
using X_O_GameNew.Interface;

namespace X_O_GameNew.Data
{
    internal class SettingsData
    {
        internal static readonly MenuFields.Menu OptionMenuPl = new MenuFields.Menu(MenuTextFields.setCustomPLayerName, MenuTextFields.setCustomPlayerMarker, MenuTextFields.goBack);
        internal static readonly MenuFields.Menu CustomChangeMenuPL = new MenuFields.Menu("1.\t"+Player.defaultName1, "2.\t" + Player.defaultName2, MenuTextFields.goBack);
        //internal static readonly MenuFields.Menu PlayerMarkerMenuPL = new MenuFields.Menu(MenuTextFields.goBack);
    }
}
