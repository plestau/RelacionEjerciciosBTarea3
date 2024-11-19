using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioB6 : MonoBehaviour
{
    public float velocidad = 5.0f;

    void Update()
    {
        transform.position += Vector3.right * velocidad * Time.deltaTime;

        if (Input.GetKeyUp(KeyCode.Space))
        {
            transform.position = Vector3.forward;
        }
    }
}