using GameGuideApp.MenuSystem.Interfaces;
using GameGuideApp.Utilities.Interfaces;

namespace GameGuideApp.MenuSystem
{
    public interface IMenu 
    { 
        public string MenuTitle { get; set; }
        public string Prompt { get; set; }
    }
}
