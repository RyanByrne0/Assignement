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
    int maxPlanets = 230;


    //Gameobjects
    public GameObject Planet;
    public GameObject Player;

    //Array
    public GameObject[] Clones;


    void Start()
    {
        Player = GameObject.Find("Player");
    }


    void Update()
    {
        Spawning();
        Clones = GameObject.FindGameObjectsWithTag("Planet");

    }

    void Spawning()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < 230; i++)
            {
                //spawn pos of buildings
                xPos = Random.Range(-4000, 4000);
                yPos = Random.Range(-150, 150);
                zPos = Random.Range(-4000, 4000);
                Instantiate(Planet, new Vector3(Player.transform.position.x + xPos, yPos, zPos), Quaternion.identity);

                //Size of buildings
                Scale = Random.Range(3, 150);
                //yScale = Random.Range(3, 30);
                //zScale = Random.Range(3, 15);
                Planet.transform.localScale = new Vector3(Scale, Scale, Scale);


            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < Clones.Length; i++)

            {
                Destroy(Clones[i]);
            }
        }
    }
}
