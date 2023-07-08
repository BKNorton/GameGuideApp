using GameGuideApp.MenuSystem.Interfaces;

namespace GameGuideApp.GamesLibrary
{
    public class Weapon : IModel
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<string> Button_Basic { get; set; } = new List<string>();
        public List<string> Attack_Basic { get; set; } = new List<string>();
    }
}
