using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public AudioSource Explosion;
    // Start is called before the first frame update
    void Start()
    {
        Explosion = GameObject.Find("Player").GetComponent<Movement>().audioClips[1];
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, GameObject.Find("Player").GetComponent<Movement>().maxSpeed * Time.deltaTime * 1.05f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Planet"))
        {
            Explosion.Play();
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
