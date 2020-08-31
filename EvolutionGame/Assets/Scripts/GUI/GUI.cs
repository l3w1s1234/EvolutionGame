using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GUI : MonoBehaviour
{

    Text planetName;
    Text creatureName;
    Button exitBtn;
    Text minTemp;
    Text maxTemp;

    GameObject dialogBox;

    // Start is called before the first frame update
    void Start()
    {
        exitBtn = transform.Find("Exit").GetComponent<Button>();
        planetName = transform.Find("PlanetNameLabel").Find("NameText").GetComponent<Text>();
        planetName.text = "Planet: " + PlanetInfo.name;

        creatureName = transform.Find("CreatureNameLabel").Find("NameText").GetComponent<Text>();
        creatureName.text = "Creature: " + CreatureInfo.creatureName;

        dialogBox = GameObject.Find("DialogBox");
        minTemp = transform.Find("DialogBox").Find("TextTempMin").GetComponent<Text>();
        maxTemp = transform.Find("DialogBox").Find("TextTempMax").GetComponent<Text>();

        dialogBox.SetActive(false);

        minTemp.text = "Min Temp: "+PlanetInfo.tempRange[0].ToString() + "°C";
        maxTemp.text ="Max Temp: "+ PlanetInfo.tempRange[1].ToString() + "°C";

        exitBtn.onClick.AddListener(exitToMenu);
    }


    void exitToMenu()
    {
        SceneManager.LoadScene("menu");
    }


    // Update is called once per frame
    void Update()
    {
        if(WorldProperties.mouseOverPlanet)
        {
            dialogBox.SetActive(true);
            dialogBox.transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
        }
        else
        {
            dialogBox.SetActive(false);
        }
    }
}
