﻿using GamesLibrary.Models;
using MenuSystem.Attributes;
using MenuSystem.Attributes.Interfaces;
using MenuSystem.Menus.MenuTemplates;

namespace GameLibrary.MonsterHunterRise.Menus
{
    public class MenuModelMonster : Menu_ModelView
    {
        IAttributes_Paragraph Desctription { get; set; }
        IAttributes_ListSingle WeakPoints { get; set; }
        IAttributes_List Tips_Gear { get; set; }
        IAttributes_List Tips_Combat { get; set; }
        public MenuModelMonster(Monster model) : base(model)
        {
            Attributes = new List<IAttributes>();
            Desctription = new Attributes_Paragraph() { Name = "Description" }; Desctription.Paragraph = model.Description; Attributes.Add(Desctription);
            WeakPoints = new Attributes_ListSingle() { Name = "WeakPoints" }; WeakPoints.AttributesList = model.WeakPoints; Attributes.Add(WeakPoints);
            Tips_Gear = new Attributes_List() { Name = "Tips_Gear" }; Tips_Gear.AttributesList = model.Tips_Gear; Attributes.Add(Tips_Gear);
            Tips_Combat = new Attributes_List() { Name = "Tips_Combat" }; Tips_Combat.AttributesList = model.Tips_Combat; Attributes.Add(Tips_Combat);
        }
    }
}
