﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    float growthSpeed;
    float Ran;
    float ExplodingTime;
  
    // Start is called before the first frame update
    void Start()
    {
        Ran = Random.Range(5, 6);
        ExplodingTime = Random.Range(4, 8);
    }
    // Update is called once per frame
    void Update()
    {
       
        Exploding();
    }

    void Exploding()
    {
        growthSpeed += Ran;
        
        transform.localScale = new Vector3(growthSpeed, growthSpeed, growthSpeed);

        ExplodingTime -= Time.deltaTime;

        if(ExplodingTime <= 0)
        {
            Destroy(this.gameObject);
        }
    }

     void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Planet"))
        {
            Destroy(other.gameObject);
        }
    }


}
