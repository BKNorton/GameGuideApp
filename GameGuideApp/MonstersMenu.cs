using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameGuideApp
{
    class MonstersMenu : Menu
    {
        public MonstersMenu()
        {
            //Parent Properties
            menuTitle = "Monsters";
            prompt = "Select a Monster";

            //Class Properies
            subMenus = new List<Menu>();

            //Add Menu options
        }

        public override void Display()
        {
            base.Display();
        }
    }
}
