using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameGuideApp
{
    internal class MonsterHunterRise : Game
    {
        //Menus
        private Menu weaponsMenu;
        private Menu monstersMenu;
        private Menu materialsMenu;

        public MonsterHunterRise()
        {
            //Parent Properties
            name = "MonsterHunterRise";

            //Class Properties
            weaponsMenu = new WeaponsMenu();
            monstersMenu = new MonstersMenu();
            materialsMenu = new MaterialsMenu();

            PopulateMenus();
        } 

        public void PopulateMenus()
        {
            menus.Add(weaponsMenu);
            menus.Add(monstersMenu);
            menus.Add(materialsMenu);
        }
 
    }
}
