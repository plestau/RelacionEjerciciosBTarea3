using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioB2 : MonoBehaviour
{
    public float rotationSpeed = 100.0f;

    void Update()
    {
        float rotation = 0.0f;

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            rotation = rotationSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            rotation = -rotationSpeed * Time.deltaTime;
        }

        transform.Rotate(0, rotation, 0);
    }
}