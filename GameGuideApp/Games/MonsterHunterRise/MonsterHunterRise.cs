using GameGuideApp.MenuSystem;

namespace GameGuideApp.Games
{
    public class MonsterHunterRise : Game
    {
        //Menus
        private Menu _weaponsMenu;
        private Menu _monstersMenu;
        private Menu _materialsMenu;

        public MonsterHunterRise()
        {
            //Parent Properties
            Name = "Monster Hunter Rise";
            GameMenu.MenuTitle = Name;

            //Class Properties
            _weaponsMenu = new MenuWeapons();
            _monstersMenu = new MenuMonsters();
            _materialsMenu = new MenuMaterials();

            //Add Menus
            GameMenu.SubMenus.Add(_weaponsMenu);
            GameMenu.SubMenus.Add(_monstersMenu);
            GameMenu.SubMenus.Add(_materialsMenu);
        } 
    }
}
