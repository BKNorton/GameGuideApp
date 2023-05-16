namespace GameGuideApp
{
    /// <summary>
    /// Anything that inherits from GameMenu overrides Display and adds input value (0) with the prompt "Back".
    /// </summary>
    public class GameMenu : Menu
    {
        public override void Display()
        {
            base.Display();
            Console.WriteLine("    0:  Back\n");
        }
    }
}
