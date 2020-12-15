using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{


    float speed = 0;
    public float maxSpeed;
    public float mouseSensitivity = 100.0f;
    public float clampAngle = 80.0f;
    private float rotY = 0.0f; 
    private float rotX = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 rot = transform.localRotation.eulerAngles;
        rotY = rot.y;
        rotX = rot.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Moving();
    }

    void Moving()
    {
        if (Input.GetKey("w"))
        {
            speed = maxSpeed * Time.deltaTime;
            transform.Translate(0, 0, speed);
        }
        else if (Input.GetKey("s"))
        {
            speed = -maxSpeed * Time.deltaTime;
            transform.Translate(0, 0, speed);
        }
        else
        {
            speed = 0;
        }

        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = -Input.GetAxis("Mouse Y");

        rotY += mouseX * mouseSensitivity * Time.deltaTime;
        rotX += mouseY * mouseSensitivity * Time.deltaTime;

        rotX = Mathf.Clamp(rotX, -clampAngle, clampAngle);

        Quaternion localRotation = Quaternion.Euler(rotX, rotY, 0.0f);
        transform.rotation = localRotation;

    }

   
}
