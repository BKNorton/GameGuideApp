using GameGuideApp.Games.MonsterHunterRise;
using GameGuideApp.Games.MonsterHunterRise.Models;
using GameGuideApp.MenuSystem.Interfaces;
using GameGuideApp.MenuSystem.MenuTemplates;

namespace GameGuideApp.Games
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
            _dataFile = @"Games\MonsterHunterRise\Data\JSON_weapons.json";
            _weapons = JsonReader.JsonFileToObjects<Weapon>(_dataFile);

            //Add Menus
            foreach (Weapon weapon in _weapons)
            {
                SubMenus.Add(new MenuModelWeapon(weapon));
            }
        }

        //string[] row = new string[2];
        //row[0] = model.Combo_Button[i];
        //row[1] = model.Combo_Attack[i];
        //Combos.Table.Add(row);
    }


}
