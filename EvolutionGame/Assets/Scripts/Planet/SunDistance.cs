using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunDistance : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(PlanetInfo.info.type == "EarthLike")
        {
            this.transform.position = new Vector3(0, 0, 30);
        }
        else if(PlanetInfo.info.type == "Hot")
        {
            this.transform.position = new Vector3(0, 0, 15);
        }
        else if (PlanetInfo.info.type == "Cold")
        {
            this.transform.position = new Vector3(0, 0, 70);
        }
    }

}
