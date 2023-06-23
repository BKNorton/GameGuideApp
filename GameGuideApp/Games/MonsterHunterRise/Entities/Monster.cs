
using GameGuideApp.MenuSystem;
using GameGuideApp.Utilities;

namespace GameGuideApp.Games
{

    public class Monster : Menu_Custom
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> WeakPoints { get; set; }
        //public Dictionary<int , string> Ailments { get; set; }
        public List<string> Tips_Gear { get; set; }
        public List<string> Tips_Combat { get; set; }

        public override string MenuToString()
        {
            //Name & Description
            return
                //base.MenuToString() +
                FormatController_Console.FormatMenuHeader(this) +
                    FormatController_Console.FormatWithBorder2(Description) +

                //WeakPoints
                FormatController_Console.FormatListWithBorder2(WeakPoints, "Weak Points") +

                //Gear Tips
                FormatController_Console.FormatWithBorder2_1(Tips_Gear, "Gear Tips") +

                //Combat Tips
                FormatController_Console.FormatWithBorder2_1(Tips_Combat, "Combat Tips");
        }
    }
}
