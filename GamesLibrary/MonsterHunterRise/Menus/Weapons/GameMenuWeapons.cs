
using GamesLibrary.Models;
using MenuSystem.Menus;
using MenuSystem.Menus.MenuTemplates;

namespace GameLibrary.MonsterHunterRise.Menus
{
    public class GameMenuWeapons : Menu_ModelList<Weapon>
    {
        public GameMenuWeapons(string path) : base(path)
        {
            //Parent Properties
            MenuTitle = "Weapons";
            Prompt = "Select a Weapon";
        }

        public override void AddModelsToSubmenu(IModel model)
        {
            SubMenus.Add(new MenuModelWeapon((Weapon)model));
        }
    }
}
