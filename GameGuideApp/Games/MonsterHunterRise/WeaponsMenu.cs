namespace GameGuideApp
{
    public class WeaponsMenu : Menu
    {
        public List<Weapon> Weapons;
        public string WeaponsDataFile;
   
        public WeaponsMenu() 
        {
            //Parent Properties
            menuTitle = "Weapons";
            prompt = "Select a Weapon";
            subMenus = new List<Menu>();

            //Class Properies
            WeaponsDataFile = @"Games\MonsterHunterRise\JSON_weapon.json";
            Weapons = JsonReader.JsonFileToObjects<Weapon>(WeaponsDataFile);

            //Add Menus
            foreach (Weapon weapon in Weapons)
            {
                weapon.menuTitle = weapon.Name;
                subMenus.Add(weapon);
            }
        }
    }
}
