using GameGuideApp.MenuSystem.MenuTemplates;
using GameGuideApp.MenuSystem.Utilities;

namespace GameGuideApp.GamesLibrary
{
    public class GameMenuMonsters : Menu_SubMenus
    {
        private List<Monster> _monsters;
        private string _dataFile;
        public GameMenuMonsters()
        {
            //Parent Properties
            MenuTitle = "Monsters";
            Prompt = "Select a Monster";
            //SubMenus = new List<IMenu>();

            //Class Properies
            _dataFile = @"MonsterHunterRise\Data\JSON_monsters.json";
            _monsters = JsonReader.JsonFileToObjects<Monster>(_dataFile);

            //Add Menus
            foreach (Monster monster in _monsters)
            {
                SubMenus.Add(new MenuModelMonster(monster));
            }
        }
    }
}
