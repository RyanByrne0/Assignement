using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingScript : MonoBehaviour
{
    public Vector3 Pos;

    public MeshRenderer[] Renderes;

    public float y;
    void Start()
    {
        Color ranColor = Random.ColorHSV(0, 1, .8f, 1);
        Pos = transform.position;
        y = Random.Range(-1 * Time.deltaTime, 1 * Time.deltaTime);
        ApplyMaterial(ranColor, 0);
    }

    void ApplyMaterial(Color color, int targetMaterialIndex)
    {
        Material generatedMat = new Material(Shader.Find("Standard"));
        generatedMat.SetColor("_Color", color);

        for(int i = 0; i < Renderes.Length; i++)
        {
            Renderes[i].material = generatedMat;
        }
    }

    public void Movement()
    {
       if(transform.position.y < -151)
        {
            y = 5 * Time.deltaTime;
        }
       else if(transform.position.y > 151)
        {
            y = -5 * Time.deltaTime;
        }

        transform.Translate(0, y, 0);
        transform.Rotate(0, y, 0);
    }

    
    void FixedUpdate()
    {
        Movement();
    }
}
