using GameGuideApp.MenuSystem;

namespace GameGuideApp.Utilities.Interfaces
{
    public interface IInputController
    {
        public string? InputString { get; set; }
        public int InputInt { get; set; }
        public string InputStatus { get; set; }

        void RecieveInput();
        bool ValidateInput();
    }
}
