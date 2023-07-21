using GameGuideApp.MenuSystem.Attributes.Interfaces;
using GameGuideApp.MenuSystem.Interfaces;

namespace GameGuideApp.Games.MonsterHunterRise.Models
{

    public class Monster : IModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> WeakPoints { get; set; }
        public List<string> Tips_Gear { get; set; }
        public List<string> Tips_Combat { get; set; }
    }
}
