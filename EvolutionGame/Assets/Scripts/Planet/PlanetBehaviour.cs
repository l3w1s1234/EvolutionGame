using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetBehaviour : MonoBehaviour
{
    public float spinRate;
    public float size;


    
    private void Start()
    {
        spinRate = PlanetInfo.info.rotationSpeed;
        size = PlanetInfo.info.planetScale;
        transform.localScale = new Vector3(size,size,size);

    }

    public void resetBehaviour()
    {
        spinRate = PlanetInfo.info.rotationSpeed;
        size = PlanetInfo.info.planetScale;
        transform.localScale = new Vector3(size, size, size);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, spinRate * Time.deltaTime, 0  );

        //change planet size if changed
        if (size != PlanetInfo.info.planetScale)
        {
            resetBehaviour();
        }
    }
}
