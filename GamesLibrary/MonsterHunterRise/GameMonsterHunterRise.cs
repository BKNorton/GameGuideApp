
using GameLibrary.MonsterHunterRise.Menus;
using MenuSystem.Menus;
using MenuSystem.Menus.MenuTemplates;

namespace GamesLibrary
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
            _weaponsMenu = new GameMenuWeapons(@"MonsterHunterRise\Data\JSON_weapons.json");
            _monstersMenu = new GameMenuMonsters(@"MonsterHunterRise\Data\JSON_monsters.json");
            _materialsMenu = new GameMenuMaterials();


            //Add Menus
            GameMenu.SubMenus.Add(_weaponsMenu);
            GameMenu.SubMenus.Add(_monstersMenu);
            GameMenu.SubMenus.Add(_materialsMenu);
        }
    }
}
