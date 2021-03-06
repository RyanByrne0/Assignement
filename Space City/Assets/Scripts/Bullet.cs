﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float BulletDuration = 20;

    public AudioSource Explosion;

    public GameObject ExplosionObject;
    // Start is called before the first frame update
    void Start()
    {
        Explosion = GameObject.Find("Player").GetComponent<Movement>().audioClips[1];
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, GameObject.Find("Player").GetComponent<Movement>().maxSpeed * Time.deltaTime * 2f);

        Duration();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Planet"))
        {
            Instantiate(ExplosionObject, new Vector3(other.transform.position.x, other.transform.position.y, other.transform.position.z), Quaternion.identity);
            Explosion.Play();
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }

    void Duration()
    {
        BulletDuration -= Time.deltaTime;

        if(BulletDuration <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
