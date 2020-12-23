using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
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
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
