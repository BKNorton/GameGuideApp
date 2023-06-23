using GameGuideApp.MenuSystem;

namespace GameGuideApp.Games
{
    public class MenuWeapons : Menu_SubMenus
    {
        private List<Weapon> _weapons;
        private string _dataFile;
   
        public MenuWeapons() 
        {
            //Parent Properties
            MenuTitle = "Weapons";
            Prompt = "Select a Weapon";
            SubMenus = new List<IMenu>();

            //Class Properies
            _dataFile = @"Games\MonsterHunterRise\Data\JSON_weapons.json";
            _weapons = JsonReader.JsonFileToObjects<Weapon>(_dataFile);

            //Add Menus
            foreach (Weapon weapon in _weapons)
            {
                weapon.MenuTitle = weapon.Name;
                SubMenus.Add(weapon);
            }
        }
    }
}
