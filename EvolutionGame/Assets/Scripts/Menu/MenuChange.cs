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
    static private bool changed = false;
    static private Menu current;
    static private Menu next;

    public static Menu Current { get => current; set => current = value; }

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

    #region getters setters
    public static void setCurrent(Menu menu)
    {
        current = menu;
    }

    public static void setNext(Menu menu)
    {
        next = menu;
    }

    public static  Menu getCurrent()
    {
        return current;
    }

    public static Menu getNext()
    {
        return next;
    }

    public static void setChanged(bool c)
    {
        changed = c;
    }

    public static bool getChanged()
    {
        return changed;
    }
    #endregion
}
