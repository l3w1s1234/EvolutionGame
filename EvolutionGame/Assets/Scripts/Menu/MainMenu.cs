using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    Button playBtn;
    Button loadBtn;
    Button exitBtn;
    Button settingsBtn;

    // Start is called before the first frame update
    void Start()
    {

        playBtn = transform.Find("Play_Button").GetComponent<Button>();
        loadBtn = transform.Find("Load_Button").GetComponent<Button>();
        exitBtn = transform.Find("Exit_Button").GetComponent<Button>();
        settingsBtn = transform.Find("Settings_Button").GetComponent<Button>();

        playBtn.onClick.AddListener(Play);
        loadBtn.onClick.AddListener(Load);
        exitBtn.onClick.AddListener(Exit);
        settingsBtn.onClick.AddListener(Settings);
        MenuChange.ChangeMenu(MenuChange.Menu.MainMenu);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void Play()
    {
        MenuChange.ChangeMenu(MenuChange.Menu.PlanetMenu);
    }

    void Load()
    {

    }

    void Settings()
    {

    }

    void Exit()
    {
        Application.Quit();
    }
}
