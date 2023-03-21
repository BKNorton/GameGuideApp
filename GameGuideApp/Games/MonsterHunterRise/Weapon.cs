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
            Name = string.Empty;
            Description = string.Empty;
            Button_Basic = new List<string>();
            Attack_Basic = new List<string>();
        }

        public override void Display()
        {
            Console.WriteLine($"\n{Name.ToUpper()} " +
                $"\n\n-- \n{Description}\n-- \n\n Basic Attacks:\n");
            for (int i = 0; i< Button_Basic.Count; i++)
            {
                Console.WriteLine(String.Format("\t  {0, -25} |\t{1, -25}", Attack_Basic[i], Button_Basic[i]));
                Console.WriteLine("\t-----------------------------------------------------------------");
            }
            Console.WriteLine("\n- 0 : Back\n");
        }
    }
}
