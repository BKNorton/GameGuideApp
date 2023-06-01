
using GameGuideApp.MenuSystem;
using GameGuideApp.Utilities;

namespace GameGuideApp.Games
{

    public class Monster : CustomMenu
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> WeakPoints { get; set; }
        //public Dictionary<int , string> Ailments { get; set; }
        public List<string> Tips_Gear { get; set; }
        public List<string> Tips_Combat { get; set; }


        public override void Display()
        {
            //Name & Description
            FormatController.WriteMenuHeader(Name);
            FormatController.WriteWithBorder2(Description);

            //WeakPoints
            FormatController.WriteWithBorder2(WeakPoints, "Weak Points");

            //Gear Tips
            FormatController.WriteWithBorder2_1(Tips_Gear, "Gear Tips");

            //Combat Tips
            FormatController.WriteWithBorder2_1(Tips_Combat, "Combat Tips");

            Console.WriteLine( "\n  - 0 : Back\n" );
        }
    }
}
