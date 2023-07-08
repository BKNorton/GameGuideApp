using GameGuideApp.MenuSystem.Interfaces;

namespace GameGuideApp.GamesLibrary
{
    public class Monster : IModel
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<string> WeakPoints { get; set; } = new List<string>();
        public List<string> Tips_Gear { get; set; } = new List<string>();
        public List<string> Tips_Combat { get; set; } = new List<string>();
    }
}
