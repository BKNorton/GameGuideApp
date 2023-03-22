namespace GameGuideApp
{
    public class MonstersMenu : GameMenu
    {
        private List<Monster> Monsters;
        private string WeaponsDataFile;
        public MonstersMenu()
        {
            //Parent Properties
            menuTitle = "Monsters";
            prompt = "Select a Monster";
            subMenus = new List<Menu>();

            //Class Properies
            WeaponsDataFile = @"Games\MonsterHunterRise\JSON_monsters.json";
            Monsters = JsonReader.JsonFileToObjects<Monster>(WeaponsDataFile);

            //Add Menus
            foreach (Monster monster in Monsters)
            {
                monster.menuTitle = monster.Name;
                subMenus.Add(monster);
            }
        }
    }
}
