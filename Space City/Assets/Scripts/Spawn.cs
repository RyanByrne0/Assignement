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


    //floats
   

    //Gameobjects
    public GameObject Planet;
    public GameObject Player;

    //Array
    public GameObject[] Clones;


    void Start()
    {
        Player = GameObject.Find("Player");
        InitialSpawn();
    }


    void FixedUpdate()
    {
       
        Spawning();
        Clones = GameObject.FindGameObjectsWithTag("Planet");
        
    }

    void Spawning()
    {

        if (Player.transform.position.x > 5000 || Player.transform.position.x < -5000 || Player.transform.position.y > 1000 || Player.transform.position.y < -1000 || Player.transform.position.z > 5000 || Player.transform.position.z < -5000)
        {
            Player.transform.position = new Vector3(0, 0, 0);

            //Destroy past planets
            for (int i = 0; i < Clones.Length; i++)

            {
                Destroy(Clones[i]);
            }

            for (int i = 0; i < 450; i++)
            {
                //spawn pos of buildings
                xPos = Random.Range(-5000, 5000);
                yPos = Random.Range(-1000, 1000);
                zPos = Random.Range(-5000, 5000);
                
                Instantiate(Planet, new Vector3(Player.transform.position.x + xPos, Player.transform.position.y + yPos, Player.transform.position.z + zPos), Quaternion.identity);
                

                //Size of buildings
                Scale = Random.Range(10, 300);
               
                Planet.transform.localScale = new Vector3(Scale, Scale, Scale);


            }
        }
        
        
         
        
    }

     void InitialSpawn()
    {
        //Initial spawn
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

   
}
