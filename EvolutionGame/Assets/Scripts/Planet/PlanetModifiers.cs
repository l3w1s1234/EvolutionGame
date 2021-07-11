using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DAL;
public static class PlanetModifiers
{

    public static readonly Dictionary<string, Planet> Planets = new Dictionary<string, Planet>();
    private static Dictionary<string, Color32> PlanetColours = new Dictionary<string, Color32>();

    //instantiate all planets
    public static void init()
    {
        var colourDataAccess = new ColoursDataAccess(CONSTANTS.GetConnection());

        PlanetColours = colourDataAccess.GetAllColours();
        
        

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
        EarthLike.landColors.Add(PlanetColours["Green"]);
        EarthLike.landColors.Add(PlanetColours["DarkGreen"]);
        EarthLike.mountainColors.Add(PlanetColours["White"]);
        EarthLike.mountainColors.Add(PlanetColours["Grey"]);
        EarthLike.waterColors.Add(PlanetColours["Blue"]);
        EarthLike.waterColors.Add(PlanetColours["DarkBlue"]);
        EarthLike.waterColors.Add(PlanetColours["LightBlue"]);
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
        HotPlanet.landColors.Add(PlanetColours["Brown"]);
        HotPlanet.landColors.Add(PlanetColours["DarkRed"]);
        HotPlanet.landColors.Add(PlanetColours["LightGrey"]);
        HotPlanet.waterColors.Add(PlanetColours["Red"]);
        HotPlanet.waterColors.Add(PlanetColours["Orange"]);
        HotPlanet.waterColors.Add(PlanetColours["Purple"]);
        HotPlanet.mountainColors.Add(PlanetColours["Grey"]);
        HotPlanet.mountainColors.Add(PlanetColours["LightRed"]);
        HotPlanet.mountainColors.Add(PlanetColours["Yellow"]);
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
        ColdPlanet.landColors.Add(PlanetColours["Purple"]);
        ColdPlanet.landColors.Add(PlanetColours["DarkGreen"]);
        ColdPlanet.landColors.Add(PlanetColours["Grey"]);
        ColdPlanet.landColors.Add(PlanetColours["White"]);
        ColdPlanet.waterColors.Add(PlanetColours["Pink"]);
        ColdPlanet.waterColors.Add(PlanetColours["LightBlue"]);
        ColdPlanet.waterColors.Add(PlanetColours["Yellow"]);
        ColdPlanet.mountainColors.Add(PlanetColours["DarkBlue"]);
        ColdPlanet.mountainColors.Add(PlanetColours["LightGrey"]);
        ColdPlanet.mountainColors.Add(PlanetColours["Pink"]);
        ColdPlanet.mountainColors.Add(PlanetColours["LightBlue"]);
        Planets.Add(ColdPlanet.type, ColdPlanet);

    }

}



