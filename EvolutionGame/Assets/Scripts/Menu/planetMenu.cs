using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class planetMenu : MonoBehaviour
{
    Button playGameBtn;
    Button backBtn;
    Button genPlanetBtn;
    Dropdown planetDropDown;
    Slider scaleSlider;
    InputField planetName;
    MessageOk messageBox;
    PerlinNoiseTerrain pt;
    PlanetBehaviour pb;

    public void Start()
    {
        if(PlanetModifiers.Planets.Count == 0)
        {
            PlanetModifiers.init();
        }
        
        planetDropDown = transform.Find("Planet_Dropdown").GetComponent<Dropdown>();

        playGameBtn = transform.Find("Next_Button").GetComponent<Button>();
        genPlanetBtn = transform.Find("Refresh_Button").GetComponent<Button>();
        playGameBtn.onClick.AddListener(PlayGame);
        genPlanetBtn.onClick.AddListener(GeneratePlanet);

        backBtn = transform.Find("Back_Button").GetComponent<Button>();
        backBtn.onClick.AddListener(Back);

        planetName = transform.Find("Input_Name").GetComponent<InputField>();

        scaleSlider = transform.Find("Scale_Slider").GetComponent<Slider>();
        scaleSlider.value = PlanetInfo.info.planetScale;
        
        messageBox = transform.Find("Message_Box").GetComponent<MessageOk>();
        pt = transform.Find("Planet_Preview").GetComponentInChildren<PerlinNoiseTerrain>();
        pb = transform.Find("Planet_Preview").GetComponentInChildren<PlanetBehaviour>();

        planetDropDown.onValueChanged.AddListener(delegate {
            changePlanetType(planetDropDown);
        });

    }

    public void Update()
    {
        PlanetInfo.info.planetScale = scaleSlider.value;
    }

    void changePlanetType(Dropdown change)
    {
        switch (change.value)
        {
            case (0):
                PlanetInfo.setInfo(PlanetModifiers.Planets["EarthLike"]);
                scaleSlider.value = PlanetInfo.info.planetScale;
                pt.Regen();
                pb.resetBehaviour();
                break;
            case (1):
                PlanetInfo.setInfo(PlanetModifiers.Planets["Hot"]);
                scaleSlider.value = PlanetInfo.info.planetScale;
                pt.Regen();
                pb.resetBehaviour();
                break;
            case (2):
                PlanetInfo.setInfo(PlanetModifiers.Planets["Cold"]);
                scaleSlider.value = PlanetInfo.info.planetScale;
                pt.Regen();
                pb.resetBehaviour();
                break;
        }
    }

    public void GeneratePlanet()
    {
        pt.Regen();
        pb.resetBehaviour();

    }

    

    void Back()
    {
        MenuChange.ChangeMenu(MenuChange.Menu.MainMenu);
    }

    public void PlayGame()
    {
        

        if(planetName.text != "" || planetName.text != null)
        {
            PlanetInfo.name = planetName.text;
        }

       

       
        if(planetName.text == "" || planetName.text == null)
        {
            messageBox.showError("Enter Planet Name");
        }
        else
        {
            //SceneManager.LoadScene("test");
            MenuChange.ChangeMenu(MenuChange.Menu.CreatureMenu);
        }
        
        
    }

}
