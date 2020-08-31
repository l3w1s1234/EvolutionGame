using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CreatureMenu : MonoBehaviour
{
    Button backBtn;
    Button playGameBtn;
    InputField creatureName;
    MessageOk messageBox;


    public void Start()
    {
        if (PlanetModifiers.Planets.Count == 0)
        {
            PlanetModifiers.init();
        }


        playGameBtn = transform.Find("Play_Button").GetComponent<Button>();
        playGameBtn.onClick.AddListener(PlayGame);


        backBtn = transform.Find("Back_Button").GetComponent<Button>();
        backBtn.onClick.AddListener(Back);

        creatureName = transform.Find("Input_Name").GetComponent<InputField>();

        messageBox = transform.Find("Message_Box").GetComponent<MessageOk>();


    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void Back()
    {
        MenuChange.ChangeMenu(MenuChange.Menu.PlanetMenu);
    }

    void PlayGame()
    {
        if(creatureName.text != "" || creatureName.text != null)
        {
            CreatureInfo.creatureName = creatureName.text;
        }
        

        if(CreatureInfo.creatureName == "")
        {
            messageBox.showError("Enter Creature Name");
        }
        else
        {
            SceneManager.LoadScene("test");
        }
        
    }
}
