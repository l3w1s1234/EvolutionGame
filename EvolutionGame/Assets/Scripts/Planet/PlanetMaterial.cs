using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetMaterial : MonoBehaviour
{
    public Material mat1;
    public Material mat2;

    MeshRenderer r;

    Ray ray;
    RaycastHit hit;

    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<MeshRenderer>();
        r.material = mat1;


        mat1.mainTexture = WorldProperties.planetTexture;
        mat2.mainTexture = WorldProperties.planetTexture;


    }

    // Update is called once per frame
    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            if(hit.collider.gameObject == this.gameObject)
            {
                if (r.material != mat1)
                {
                    mat2.mainTexture = WorldProperties.planetTexture;
                    WorldProperties.mouseOverPlanet = true;
                    r.material = mat2;
                }
            }
            


        }
        else
        {
            if (r.material != mat2)
            {
                mat1.mainTexture = WorldProperties.planetTexture;
                WorldProperties.mouseOverPlanet = false;
                r.material = mat1;
            }
        }
    }
}
