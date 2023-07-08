using GameGuideApp.MenuSystem.MenuTemplates;
using GameGuideApp.MenuSystem.Utilities;

namespace GameGuideApp.GamesLibrary
{
    public class GameMenuWeapons : Menu_SubMenus
    {
        private List<Weapon> _weapons;
        private string _dataFile;

        public GameMenuWeapons()
        {
            //Parent Properties
            MenuTitle = "Weapons";
            Prompt = "Select a Weapon";

            //Class Properies
            _dataFile = @"MonsterHunterRise\Data\JSON_weapons.json";
            _weapons = JsonReader.JsonFileToObjects<Weapon>(_dataFile);

            //Add Menus
            foreach (Weapon weapon in _weapons)
            {
                SubMenus.Add(new MenuModelWeapon(weapon));
            }
        }
    }
}
