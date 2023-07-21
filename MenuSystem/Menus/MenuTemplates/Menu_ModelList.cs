
using GameGuideApp.MenuSystem.Utilities;

namespace MenuSystem.Menus.MenuTemplates
{
    /// <summary>
    /// This menu template is abstract and requires a string path to the json data of the models to be passed as an argument through the constructor.
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    public abstract class Menu_ModelList<TModel> : Menu_SubMenus where TModel : IModel 
    {
        public List<TModel> ModelList;

        public Menu_ModelList(string JSONPath) 
        {
            ModelList = JsonReader.JsonFileToObjects<TModel>(JSONPath);

            //Add Menus
            foreach (IModel model in ModelList)
            {
                AddModelsToSubmenu(model);
            }
        }

        /// <summary>
        /// When a subclass overrides this method, it must use the model argument to create a type of Menu_ModelView and add it to SubMenus.
        /// </summary>
        /// <param name="model"></param>
        public abstract void AddModelsToSubmenu(IModel model);
    }
}
