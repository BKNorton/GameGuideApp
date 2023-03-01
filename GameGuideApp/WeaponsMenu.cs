using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameGuideApp
{
    internal class WeaponsMenu : Menu
    {
        private List<Menu> subMenus;
        
        public WeaponsMenu() 
        {
            //Parent Properties
            menuTitle = "Weapons";
            prompt = "Select a Weapon";

            //Class Properies
            subMenus= new List<Menu>();

            //Add Menu options
        }

        public void Display()
        {
            base.Display();

        }
    }
}
