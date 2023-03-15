using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameGuideApp
{
    public class WeaponsMenu : Menu
    {
        public WeaponsMenu() 
        {
            //Parent Properties
            menuTitle = "Weapons";
            prompt = "Select a Weapon";
            subMenus = new List<Menu>();

            //Class Properies

            //Add Menu options
        }

        public override void Display()
        {
            base.Display();
        }
    }
}
