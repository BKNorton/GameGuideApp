

using GameGuideApp.Utilities.Interfaces;

namespace GameGuideApp.MenuSystem.Interfaces
{
    public interface IInteractable
    {
        public bool Interact(IInputController inputController, Navigation_Menu nav);
    }
}
