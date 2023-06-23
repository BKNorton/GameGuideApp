using GameGuideApp.MenuSystem;
using GameGuideApp.MenuSystem.Interfaces;
using GameGuideApp.Utilities;

namespace GameGuideApp.Games
{
    public class Weapon : Menu_Custom
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Button_Basic { get; set; }
        public List<string> Attack_Basic { get; set; }

        public override string MenuToString()
        {
            return
                //Name & Description
                FormatController_Console.FormatMenuHeader(this) +
                FormatController_Console.FormatWithBorder1(Description) +

                //Basic Attacks
                FormatController_Console.FormatTwoColTable(Attack_Basic, Button_Basic, "Basic Attacks");
        }
    }
}
