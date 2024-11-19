using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio : MonoBehaviour
{
    public float velocidad = 1.0f;

    void Update()
    {
        transform.position += Vector3.right * velocidad * Time.deltaTime;

        if (transform.position.x >= 10.0f)
        {
            transform.position = new Vector3(0, transform.position.y, transform.position.z);
        }
    }
}