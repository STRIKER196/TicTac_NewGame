using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_O_GameNew.Interface
{
    internal class MenuFields
    {
        public class Menu
        {
            public string OptionOne { get; set; }
            public string? OptionTwo { get; set; }
            public string? OptionThree { get; set; }
            public string? OptionFour { get; set; }


            public Menu(string optionOne, string? optionTwo = null, string? optionThree = null, string? optionFour = null)
            {
                OptionOne = optionOne;
                OptionTwo = optionTwo;
                OptionThree = optionThree;
                OptionFour = optionFour;
            }
        }
    }
}
