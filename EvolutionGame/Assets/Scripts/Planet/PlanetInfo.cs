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

        tempRange[0] = Random.Range(info.minTemp, info.midTemp);
        tempRange[1] = Random.Range(tempRange[0], info.maxTemp);

        //round to 2 decimal places
        tempRange[0] = (float)System.Math.Round(tempRange[0], 2);
        tempRange[1] = (float)System.Math.Round(tempRange[1], 2);

    }
}
