using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MenuChange 
{
    //different menus represented as enum
    public enum Menu
    {
        PlanetMenu,
        CreatureMenu,
        MainMenu
    }
    static public bool changed = false;
    static public Menu current;
    static public Menu next;

    static public void init()
    {
        changed = true;
    }

    //called by menu buttons when wanting to change menu
    public static void ChangeMenu(Menu nextMenu)
    {
        changed = true;
        next = nextMenu;
    }
}
