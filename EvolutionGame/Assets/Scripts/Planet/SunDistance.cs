﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunDistance : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

       this.transform.position = new Vector3(0, 0, PlanetInfo.info.planetDistance);
        
    }

}
