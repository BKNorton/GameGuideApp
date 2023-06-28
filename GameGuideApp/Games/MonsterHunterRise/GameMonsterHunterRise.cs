using GameGuideApp.MenuSystem;
using GameGuideApp.MenuSystem.MenuTemplates;

namespace GameGuideApp.Games.MonsterHunterRise
{
    public class GameMonsterHunterRise : Game
    {
        //Menus
        private Menu _weaponsMenu;
        private Menu _monstersMenu;
        private Menu _materialsMenu;

        public GameMonsterHunterRise()
        {
            //Parent Properties
            GameMenu.MenuTitle = Name = "Monster Hunter Rise";

            //Class Properties
            _weaponsMenu = new GameMenuWeapons();
            _monstersMenu = new GameMenuMonsters();
            _materialsMenu = new GameMenuMaterials();

            //Add Menus
            GameMenu.SubMenus.Add(_weaponsMenu);
            GameMenu.SubMenus.Add(_monstersMenu);
            GameMenu.SubMenus.Add(_materialsMenu);
        } 
    }
}
