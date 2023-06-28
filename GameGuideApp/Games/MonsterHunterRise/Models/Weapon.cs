using GameGuideApp.MenuSystem;
using GameGuideApp.MenuSystem.Interfaces;

namespace GameGuideApp.Games.MonsterHunterRise.Models
{
    public class Weapon : IModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Button_Basic { get; set; }
        public List<string> Attack_Basic { get; set; }

        //public  string MenuToString()
        //{
        //    return
        //        //Name & Description
        //        FormatController_Console.FormatMenuHeader(this) +
        //        FormatController_Console.FormatWithBorder1(Description) +

        //        //Basic Attacks
        //        FormatController_Console.FormatTwoColTable(Attack_Basic, Button_Basic, "Basic Attacks");
        //}
    }
}
