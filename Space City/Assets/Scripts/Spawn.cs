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
            for (int i = 0; i < 250; i++)
            {
                //spawn pos of buildings
                xPos = Random.Range(-4000, 4000);
                yPos = Random.Range(-350, 350);
                zPos = Random.Range(-4000, 4000);
                Instantiate(Planet, new Vector3(Player.transform.position.x + xPos, Player.transform.position.y + yPos, Player.transform.position.z + zPos), Quaternion.identity);
                

                //Size of buildings
                Scale = Random.Range(3, 250);
               
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
