namespace GameGuideApp
{
    public class Weapon : LastMenu
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Button_Basic { get; set; }
        public List<string> Attack_Basic { get; set; }

        public Weapon()
        {
            //Parent Properties
            prompt = string.Empty;
            menuTitle = Name!;

            //Class Properties
            Name = Description = string.Empty;
            Button_Basic = Attack_Basic = new List<string>();
        }

        public override void Display()
        {
            Console.WriteLine($"\n{Name.ToUpper()} " +
                $"\n\n--  \t\t\t\t\t\t\t\t\t\t  --\n {Description} " +
                $"\n--  \t\t\t\t\t\t\t\t\t\t  --\n\n Basic Attacks:\n");
            for (int i = 0; i< Button_Basic.Count; i++)
            {
                Console.WriteLine(String.Format("  {0, -25} |   {1, -25}", Attack_Basic[i], Button_Basic[i]));
                Console.WriteLine("  ---------------------------------------------------------------------");
            }
            Console.WriteLine("\n- 0 : Back");
        }
    }
}
