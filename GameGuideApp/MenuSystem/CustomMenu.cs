namespace GameGuideApp.MenuSystem
{
    public class CustomMenu : Menu, IMenu_Custom
    {
        public override void Display()
        {
            Console.WriteLine(ToStringForDisplay());
        }

        public virtual string ToStringForDisplay()
        {
            return MenuTitle + " :\n" + Prompt + " :\n";
        }
    }
}
