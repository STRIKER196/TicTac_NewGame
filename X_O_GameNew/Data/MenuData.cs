using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X_O_GameNew.Consts;
using X_O_GameNew.Interface;

namespace X_O_GameNew.Data
{
    internal class MenuData
    {
        internal static readonly MenuFields.Menu MainMenuPl = new MenuFields.Menu(MenuTextFields.play, MenuTextFields.settings, MenuTextFields.exit);
    }
}
