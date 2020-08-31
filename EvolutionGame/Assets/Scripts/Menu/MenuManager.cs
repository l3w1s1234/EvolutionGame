using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    Dictionary<MenuChange.Menu, GameObject> Menus;

    // Start is called before the first frame update
    void Start()
    {
        MenuChange.init();

        Menus = new Dictionary<MenuChange.Menu,GameObject>();

        Menus.Add(MenuChange.Menu.PlanetMenu,GameObject.Find("Planet_Menu"));
        Menus.Add(MenuChange.Menu.CreatureMenu,GameObject.Find("Creature_Menu"));
        Menus.Add(MenuChange.Menu.MainMenu,GameObject.Find("Main_Menu"));

        //deactivate all menus
        foreach(GameObject go in Menus.Values)
        {
            go.SetActive(false);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        //de/activate menus on change
        if (MenuChange.changed == true)
        {
            changeMenu();
        }
       

    }

    //change to next menu and set current menu
    void changeMenu()
    {
        Menus[MenuChange.current].SetActive(false);
        Menus[MenuChange.next].SetActive(true);
        MenuChange.changed = false;
        MenuChange.current = MenuChange.next;
    }
}
