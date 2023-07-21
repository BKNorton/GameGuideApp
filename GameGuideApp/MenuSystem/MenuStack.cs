

namespace GameGuideApp.MenuSystem
{
    /// <summary>
    /// Creates a Menu Stack to navigate through the Menus. 
    /// </summary>
    public class MenuStack<T> where T : IMenu
    {
        private Stack<T> _path = new Stack<T>();
        public bool IsEmpty { get => _path.Count == 0 ? true : false ; } 

        public void Next(T item)
        {
            _path.Push(item);
        }

        public void Previous()
        {
            if (_path.Count != 0)
            {
                _path.Pop();
            }
        } 
    }   
}
