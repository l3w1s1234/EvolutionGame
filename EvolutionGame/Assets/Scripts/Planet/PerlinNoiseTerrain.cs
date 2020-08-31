using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PerlinNoiseTerrain : MonoBehaviour
{
    public KeyCode regenKey;
    int waterIndex;
    int landIndex;
    int mountainIndex;

    

    public int width= 1024;
    public int height = 1024;


    public float scale = 20f;

    public float offsetX = 0f;
    public float offsetY = 0f;

    // Start is called before the first frame update
    void Start()
    {
        //set planet to earthlike if null
        if (PlanetInfo.info.landColors == null)
        {
            PlanetModifiers.init();

            PlanetInfo.setInfo(PlanetModifiers.Planets["EarthLike"]);
        }

        waterIndex = Random.Range(0, PlanetInfo.info.waterColors.Count);
        landIndex = Random.Range(0, PlanetInfo.info.landColors.Count);
        mountainIndex = Random.Range(0, PlanetInfo.info.mountainColors.Count);

        if(WorldProperties.planetTexture == null)
        {
            WorldProperties.planetTexture = GenerateTexture();
        }

    }

    public void Regen()
    {
        waterIndex = Random.Range(0, PlanetInfo.info.waterColors.Count);
        landIndex = Random.Range(0, PlanetInfo.info.landColors.Count);
        mountainIndex = Random.Range(0, PlanetInfo.info.mountainColors.Count);
        int newNoise = Random.Range(0, 10000);
        this.offsetX = (float)newNoise;
        this.offsetY = (float)newNoise;
        WorldProperties.planetTexture = GenerateTexture();
    }

    //use for debug
    private void Update()
    {
         
        if (Input.GetKeyDown(regenKey))
        {
            waterIndex = Random.Range(0, PlanetInfo.info.waterColors.Count);
            landIndex = Random.Range(0, PlanetInfo.info.landColors.Count);
            mountainIndex = Random.Range(0, PlanetInfo.info.mountainColors.Count);




            int newNoise = Random.Range(0, 10000);
            this.offsetX = (float)newNoise;
            this.offsetY = (float)newNoise;

           
            WorldProperties.planetTexture = GenerateTexture();
        }

        
    }

    //
    Texture GenerateTexture()
    {

        Texture2D texture = new Texture2D(width, height);

        //loop through the height and width for each pixel
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {

                Color32 color = CalculateColor(x,y);
                texture.SetPixel(x, y, color);
                
               
            }
        }

        texture.Apply();
        
        return texture;
    }

    Color32 CalculateColor(float x, float y)
    {
        float xCoord = (float)x / width * scale + offsetX;
        float yCoord = (float)y / height * scale + offsetY;

        //float noiseValue = cylindernoise(xCoord, yCoord);
       float noiseValue = Mathf.PerlinNoise(xCoord, yCoord); 
        
        

     
        if (noiseValue < PlanetInfo.info.waterVolume)
        {
            
            return PlanetInfo.info.waterColors[waterIndex];
        }
        else if (noiseValue < PlanetInfo.info.landMass)
        {

            return PlanetInfo.info.landColors[landIndex];
        }
        else if (noiseValue < 1)
        {
            
            return PlanetInfo.info.mountainColors[mountainIndex];
        }
        
            return new Color(noiseValue, noiseValue, noiseValue);
    }

    const float TAU = 2 * Mathf.PI;

    float cylindernoise(float nx, float ny)
    {

        float angle_x = TAU * nx;
        nx = Mathf.PerlinNoise(Mathf.Cos(angle_x) / TAU, Mathf.Sin(angle_x) / TAU);
        

        return Mathf.PerlinNoise(nx * scale + offsetX,ny*scale + offsetY);
    }

    

}
