using GameGuideApp.MenuSystem;
using GameGuideApp.Utilities;

namespace GameGuideApp.Games
{
    public class Weapon : CustomMenu
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Button_Basic { get; set; }
        public List<string> Attack_Basic { get; set; }

        public override void Display()
        {
            //Name & Description
            FormatController.WriteMenuHeader(Name);
            FormatController.WriteWithBorder1(Description);

            //Basic Attacks
            FormatController.DisplayTwoColTable(Attack_Basic, Button_Basic, "Basic Attacks");

            Console.WriteLine("\n  - 0 : Back\n");
        }
    }
}
