using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class PlanetInfo
{
    public static Planet info;
    public static string name;

    public static float[] tempRange;

    public static void setInfo(Planet i)
    {
        info = i;
        tempRange = new float[2];

        //set the min and max temp of planet based on its type
        switch(info.type)
        {
            case ("Hot"):
                tempRange[0] = Random.Range(100f, 300f);
                tempRange[1] = Random.Range(tempRange[0], 500f);
                break;
            case ("EarthLike"):
                tempRange[0] = Random.Range(-30f, 40f);
                tempRange[1] = Random.Range(tempRange[0], 70f);
                break;
            case ("Cold"):
                tempRange[0] = Random.Range(-300f, -100f);
                tempRange[1] = Random.Range(tempRange[0], 0f);
                break;
        }

        //round to 2 decimal places
        tempRange[0] = (float)System.Math.Round(tempRange[0], 2);
        tempRange[1] = (float)System.Math.Round(tempRange[1], 2);

    }
}
