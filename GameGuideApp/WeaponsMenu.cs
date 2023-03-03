using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameGuideApp
{
    class WeaponsMenu : Menu
    {
        public WeaponsMenu() 
        {
            //Parent Properties
            menuTitle = "Weapons";
            prompt = "Select a Weapon";

            //Class Properies
            subMenus= new List<Menu>();

            //Add Menu options
        }

        public override void Display()
        {
            base.Display();
        }
    }
}
