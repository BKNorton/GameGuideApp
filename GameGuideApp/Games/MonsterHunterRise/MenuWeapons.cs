using GameGuideApp.MenuSystem;

namespace GameGuideApp.Games
{
    public class MenuWeapons : GameMenu
    {
        private List<Weapon> _weapons;
        private string _dataFile;
   
        public MenuWeapons() 
        {
            //Parent Properties
            menuTitle = "Weapons";
            prompt = "Select a Weapon";
            subMenus = new List<Menu>();

            //Class Properies
            _dataFile = @"Games\MonsterHunterRise\Data\JSON_weapons.json";
            _weapons = JsonReader.JsonFileToObjects<Weapon>(_dataFile);

            //Add Menus
            foreach (Weapon weapon in _weapons)
            {
                weapon.menuTitle = weapon.Name;
                subMenus.Add(weapon);
            }
        }
    }
}
