using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameGuideApp
{
    class MonsterHunterRise : Game
    {
        //Menus
        private Menu weaponsMenu;
        private Menu monstersMenu;
        private Menu materialsMenu;

        public MonsterHunterRise()
        {
            //Parent Properties
            name = "MonsterHunterRise";
            gameMenu = new Menu();
            {
                gameMenu.menuTitle = name;
                gameMenu.prompt = "Select menu";
            }
            
            //Initiate Menus
            weaponsMenu = new WeaponsMenu();
            monstersMenu = new MonstersMenu();
            materialsMenu = new MaterialsMenu();

            //Add Menus
            gameMenu.subMenus.Add(weaponsMenu);
            gameMenu.subMenus.Add(monstersMenu);
            gameMenu.subMenus.Add(materialsMenu);
        } 
    }
}
