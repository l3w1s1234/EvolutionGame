using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    

    [System.Serializable]
    public struct Menus
    {
        public MenuChange.Menu key;
        public GameObject value;
    }

    public Menus[] menuArr;
    Dictionary<MenuChange.Menu, GameObject> menus = new Dictionary<MenuChange.Menu, GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        MenuChange.init();
        
        //add menus from editor
        for(int i = 0; i<menuArr.Length; i++)
        {
            menus.Add(menuArr[i].key, menuArr[i].value);
        }

        //deactivate all menus
        foreach(GameObject go in menus.Values)
        {
            go.SetActive(false);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        //de/activate menus on change
        if (MenuChange.getChanged() == true)
        {
            changeMenu();
        }
       

    }

    //change to next menu and set current menu
    void changeMenu()
    {
        menus[MenuChange.getCurrent()].SetActive(false);
        menus[MenuChange.getNext()].SetActive(true);
        MenuChange.setChanged(false);
        MenuChange.setCurrent(MenuChange.getNext());
    }
}
