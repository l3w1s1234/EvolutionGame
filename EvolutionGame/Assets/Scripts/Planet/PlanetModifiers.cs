using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlanetModifiers
{

    public static readonly Dictionary<string, Planet> Planets = new Dictionary<string, Planet>();

    //instantiate all planets
    public static void init()
    {
        //Earthlike
        //planet constraints
        Planet EarthLike = new Planet();
        EarthLike.type = "EarthLike";
        EarthLike.landMass = 0.7f;
        EarthLike.waterVolume = 0.5f;
        EarthLike.planetScale = 1f;
        EarthLike.rotationSpeed = 15f;

        //planet colors
        EarthLike.landColors = new List<Color32>();
        EarthLike.waterColors = new List<Color32>();
        EarthLike.mountainColors = new List<Color32>();
        EarthLike.landColors.Add(PlanetColors.green);
        EarthLike.landColors.Add(PlanetColors.darkGreen);
        EarthLike.mountainColors.Add(PlanetColors.white);
        EarthLike.mountainColors.Add(PlanetColors.grey);
        EarthLike.waterColors.Add(PlanetColors.blue);
        EarthLike.waterColors.Add(PlanetColors.darkBlue);
        EarthLike.waterColors.Add(PlanetColors.lightBlue);
        Planets.Add(EarthLike.type, EarthLike);


        //HotPlanet
        Planet HotPlanet = new Planet();
        HotPlanet.type = "Hot";
        HotPlanet.landMass = 0.85f;
        HotPlanet.waterVolume = 0.5f;
        HotPlanet.planetScale = 0.7f;
        HotPlanet.rotationSpeed = 10f;

        //planet colors
        HotPlanet.landColors = new List<Color32>();
        HotPlanet.waterColors = new List<Color32>();
        HotPlanet.mountainColors = new List<Color32>();
        HotPlanet.landColors.Add(PlanetColors.brown);
        HotPlanet.landColors.Add(PlanetColors.darkRed);
        HotPlanet.landColors.Add(PlanetColors.lightGrey);
        HotPlanet.waterColors.Add(PlanetColors.red);
        HotPlanet.waterColors.Add(PlanetColors.orange);
        HotPlanet.waterColors.Add(PlanetColors.purple);
        HotPlanet.mountainColors.Add(PlanetColors.grey);
        HotPlanet.mountainColors.Add(PlanetColors.lightRed);
        HotPlanet.mountainColors.Add(PlanetColors.yellow);
        Planets.Add(HotPlanet.type, HotPlanet);

        //ColdPlanet
        Planet ColdPlanet = new Planet();
        ColdPlanet.type = "Cold";
        ColdPlanet.landMass = 0.83f;
        ColdPlanet.waterVolume = 0.4f;
        ColdPlanet.planetScale = 2f;
        ColdPlanet.rotationSpeed = 25f;

        //planet colors
        ColdPlanet.landColors = new List<Color32>();
        ColdPlanet.waterColors = new List<Color32>();
        ColdPlanet.mountainColors = new List<Color32>();
        ColdPlanet.landColors.Add(PlanetColors.purple);
        ColdPlanet.landColors.Add(PlanetColors.darkGreen);
        ColdPlanet.landColors.Add(PlanetColors.grey);
        ColdPlanet.landColors.Add(PlanetColors.white);
        ColdPlanet.waterColors.Add(PlanetColors.pink);
        ColdPlanet.waterColors.Add(PlanetColors.lightBlue);
        ColdPlanet.waterColors.Add(PlanetColors.yellow);
        ColdPlanet.mountainColors.Add(PlanetColors.darkBlue);
        ColdPlanet.mountainColors.Add(PlanetColors.lightGrey);
        ColdPlanet.mountainColors.Add(PlanetColors.pink);
        ColdPlanet.mountainColors.Add(PlanetColors.lightBlue);
        Planets.Add(ColdPlanet.type, ColdPlanet);



    }

}

//list of colors for planets
public struct PlanetColors
{
    public static Color32 red = new Color32(255, 0, 0,1);
    public static Color32 darkRed = new Color32(102, 0, 0, 1);
    public static Color32 lightRed = new Color32(255, 102, 102, 1);
    public static Color32 lightBlue = new Color32(102, 102, 255,1);
    public static Color32 blue = new Color32(0, 0, 255,1);
    public static Color32 darkBlue = new Color32(0, 0, 153,1);
    public static Color32 green = new Color32(0, 255, 0,1);
    public static Color32 darkGreen = new Color32(0, 153, 0,1);
    public static Color32 white = new Color32(255, 255, 255,1);
    public static Color32 yellow = new Color32(255,255,51,1);
    public static Color32 grey = new Color32(128, 128, 128,1);
    public static Color32 lightGrey = new Color32(192, 192, 192, 1);
    public static Color32 purple = new Color32(153, 0, 153, 1);
    public static Color32 orange = new Color32(255, 128, 0, 1);
    public static Color32 pink = new Color32(255, 102, 178, 1);
    public static Color32 brown = new Color32(102, 51, 0, 1);


}

