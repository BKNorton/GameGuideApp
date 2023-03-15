using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameGuideApp
{
    public class MonstersMenu : Menu
    {
        public MonstersMenu()
        {
            //Parent Properties
            menuTitle = "Monsters";
            prompt = "Select a Monster";
            subMenus = new List<Menu>();

            //Class Properies

            //Add Menu options
        }

        public void Display()
        {
            base.Display();
        }
    }
}
