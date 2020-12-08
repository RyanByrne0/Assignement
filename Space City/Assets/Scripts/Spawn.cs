using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public int xPos;
    public int yPos;
    public int zPos;
    public GameObject Building;
    void Start()
    {
        Spawning();
    }

    
    void Update()
    {
        
    }

    void Spawning()
    {
        for(int i = 0; i < 100; i++)
        {
            xPos = Random.Range(-50, 50);
            yPos = Random.Range(-5, 5);
            zPos = Random.Range(-50, 50);
            Instantiate(Building, new Vector3(xPos, yPos, zPos), Quaternion.identity);
        }
    }
}
