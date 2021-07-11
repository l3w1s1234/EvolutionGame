using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DAL;

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
        populateDropdown();
        planetDropDown.onValueChanged.AddListener(delegate {
            changePlanetType(planetDropDown);
        });


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

        

    }

    private void populateDropdown()
    {
        var planetTypeDataAccess = new PlanetTypesDataAccess(CONSTANTS.GetConnection());
        var planetTypes = planetTypeDataAccess.GetPlanetTypeNames();

        planetDropDown.AddOptions(planetTypes);
    }

    public void Update()
    {
        PlanetInfo.info.planetScale = scaleSlider.value;
    }

    void changePlanetType(Dropdown change)
    {

        PlanetInfo.setInfo(PlanetModifiers.Planets[change.options[change.value].text]);
        scaleSlider.value = PlanetInfo.info.planetScale;
        pt.Regen();
        pb.resetBehaviour();
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
