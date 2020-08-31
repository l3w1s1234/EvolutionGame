using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Planet
{
    public float waterVolume;
    public float landMass;

    public string type;

    public List<Color32> waterColors;
    public List<Color32> landColors;
    public List<Color32> mountainColors;

    public float rotationSpeed;
    public float planetScale;

}