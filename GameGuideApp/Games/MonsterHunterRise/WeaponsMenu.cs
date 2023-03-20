using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameGuideApp
{
    public class WeaponsMenu : Menu
    {
        public List<Weapon> Weapons;
        public string WeaponsDataFile;
        public string WeaponsJsonString;
        public WeaponsMenu() 
        {
            //Parent Properties
            menuTitle = "Weapons";
            prompt = "Select a Weapon";
            subMenus = new List<Menu>();

            //Class Properies
            Weapons = new List<Weapon>();
            WeaponsDataFile = @"Games\MonsterHunterRise\JSON_weapon.json";
            Weapons = JsonReader.JsonToObjects<Weapon>(WeaponsDataFile);

            //Add Menu options
            foreach (Weapon weapon in Weapons)
            {
                weapon.menuTitle = weapon.Name;
                subMenus.Add(weapon);
            }
        }
    }
}
