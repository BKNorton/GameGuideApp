using GameGuideApp.MenuSystem;

namespace GameGuideApp.Games
{
    public class MenuMonsters : GameMenu
    {
        private List<Monster> _monsters;
        private string _dataFile;
        public MenuMonsters()
        {
            //Parent Properties
            menuTitle = "Monsters";
            prompt = "Select a Monster";
            subMenus = new List<Menu>();

            //Class Properies
            _dataFile = @"Games\MonsterHunterRise\Data\JSON_monsters.json";
            _monsters = JsonReader.JsonFileToObjects<Monster>(_dataFile);

            //Add Menus
            foreach (Monster monster in _monsters)
            {
                monster.menuTitle = monster.Name;
                subMenus.Add(monster);
            }
        }
    }
}
