using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entities;
using DAL;


//class gets all the planet types
public static class PlanetModifiers
{

    public static readonly Dictionary<string, Planet> Planets = new Dictionary<string, Planet>();
    private static Dictionary<string, Color32> PlanetColours = new Dictionary<string, Color32>();
    private static List<ColourTypes> ColourTypes = new List<ColourTypes>();
    private static List<PlanetTypes> PlanetTypes = new List<PlanetTypes>();

    //data access to get Colours and Planet types
    private static ColoursDataAccess colourDataAccess = new ColoursDataAccess(CONSTANTS.GetConnection());
    private static PlanetTypesDataAccess planetTypesDataAccess = new PlanetTypesDataAccess(CONSTANTS.GetConnection());


    //instantiate all planets
    public static void init()
    {

        PlanetColours = colourDataAccess.GetAllColours();
        ColourTypes = colourDataAccess.GetColourTypes();
        PlanetTypes = planetTypesDataAccess.GetPlanetTypes();

        setupPlanetTypes();
    }


    private static void setupPlanetTypes()
    {
        foreach (var pt in PlanetTypes)
        {
            var planet = new Planet();

            planet.type = pt.Type;
            planet.planetScale = pt.PlanetScale;
            planet.rotationSpeed = pt.RotationSpeed;
            planet.landMass = pt.LandMass;
            planet.waterVolume = pt.WaterVolume;
            planet.planetDistance = pt.PlanetDistance;
            planet.minTemp = pt.MinTemp;
            planet.midTemp = pt.MidTemp;
            planet.maxTemp = pt.MaxTemp;

            planet.waterColors = new List<Color32>();
            planet.landColors = new List<Color32>();
            planet.mountainColors = new List<Color32>();

            //set colours for each colour type e.g land,water,mountains
            foreach (var ct in ColourTypes)
            {
                var colours = planetTypesDataAccess.getPlanetColours(pt,ct);
                //add each colour
                foreach(var col in colours)
                {
                    setPlanetColours(planet,ct,col);
                }
            }

            Planets.Add(planet.type, planet);
        }
    }

    private static void setPlanetColours(Planet p, ColourTypes ct, Colours col)
    {
        switch(ct.Name)
        {
            case "Land": p.landColors.Add(PlanetColours[col.Name]); break;
            case "Water": p.waterColors.Add(PlanetColours[col.Name]); break;
            case "Mountain": p.mountainColors.Add(PlanetColours[col.Name]); break;
        }
    }

}



