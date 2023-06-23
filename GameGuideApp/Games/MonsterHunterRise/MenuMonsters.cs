using GameGuideApp.MenuSystem;

namespace GameGuideApp.Games
{
    public class MenuMonsters : Menu_SubMenus
    {
        private List<Monster> _monsters;
        private string _dataFile;
        public MenuMonsters()
        {
            //Parent Properties
            MenuTitle = "Monsters";
            Prompt = "Select a Monster";
            SubMenus = new List<IMenu>();

            //Class Properies
            _dataFile = @"Games\MonsterHunterRise\Data\JSON_monsters.json";
            _monsters = JsonReader.JsonFileToObjects<Monster>(_dataFile);

            //Add Menus
            foreach (Monster monster in _monsters)
            {
                monster.MenuTitle = monster.Name;
                SubMenus.Add(monster);
            }
        }
    }
}
