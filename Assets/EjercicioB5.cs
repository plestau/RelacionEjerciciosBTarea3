using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioB5 : MonoBehaviour
{
    public float velocidad = 5.0f;

    void Update()
    {
        float x = 0.0f;
        float z = 0.0f;

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            x = - velocidad * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            x = velocidad * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            z = velocidad * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            z = - velocidad * Time.deltaTime;
        }

        transform.position += new Vector3(x, 0, z);
    }
}