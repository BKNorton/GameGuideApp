using GameGuideApp.MenuSystem;

namespace GameGuideApp
{
    public interface IInputController
    {
        int GetInputInt();
        string GetInputString();
        void RecieveInput();
        bool ValidateInput(Menu menu, out string message);
    }
}