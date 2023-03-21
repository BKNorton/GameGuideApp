namespace GameGuideApp
{
    public class MonsterHunterRise : Game
    {
        //Menus
        private Menu weaponsMenu;
        private Menu monstersMenu;
        private Menu materialsMenu;

        public MonsterHunterRise()
        {
            //Parent Properties
            name = "Monster Hunter Rise";
            gameMenu.menuTitle = name;

            //Initiate Menus
            weaponsMenu = new WeaponsMenu();
            monstersMenu = new MonstersMenu();
            materialsMenu = new MaterialsMenu();

            //Add Menus
            gameMenu.subMenus.Add(weaponsMenu);
            gameMenu.subMenus.Add(monstersMenu);
            gameMenu.subMenus.Add(materialsMenu);
        } 
    }
}
