using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameGuideApp
{
    internal class MonstersMenu : Menu
    {
        private List<Menu> subMenus;

        public MonstersMenu()
        {
            //Parent Properties
            menuTitle = "Monsters";
            prompt = "Select a Monster";

            //Class Properies
            subMenus = new List<Menu>();

            //Add Menu options
        }

        public void Display()
        {
            base.Display();

        }
    }
}
