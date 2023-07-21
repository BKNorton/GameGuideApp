
using GamesLibrary.Models;
using MenuSystem.Menus;
using MenuSystem.Menus.MenuTemplates;

namespace GameLibrary.MonsterHunterRise.Menus
{
    public class GameMenuMonsters : Menu_ModelList<Monster>
    {
        public GameMenuMonsters(string path) : base(path)
        {
            //Parent Properties
            MenuTitle = "Monsters";
            Prompt = "Select a Monster";
        }

        public override void AddModelsToSubmenu(IModel model)
        {
            SubMenus.Add(new MenuModelMonster((Monster)model));
        }
    }
}
