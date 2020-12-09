using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    //ints
    public int xPos;
    public int yPos;
    public int zPos;
    int Scale;
    int yScale;
    int zScale;

    //Gameobjects
    public GameObject Planet;
    void Start()
    {
        Spawning();
    }

    
    void Update()
    {
        
    }

    void Spawning()
    {
        for(int i = 0; i < 200; i++)
        {
            //spawn pos of buildings
            xPos = Random.Range(-2000, 2000);
            yPos = Random.Range(-150, 150);
            zPos = Random.Range(-2000, 2000);
            Instantiate(Planet, new Vector3(xPos, yPos, zPos), Quaternion.identity);

            //Size of buildings
            Scale = Random.Range(3, 100);
            //yScale = Random.Range(3, 30);
            //zScale = Random.Range(3, 15);
           Planet.transform.localScale = new Vector3(Scale, Scale, Scale);
        }
    }
}
