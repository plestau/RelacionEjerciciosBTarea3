using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioB4 : MonoBehaviour
{
    public float speed = 1.0f;
    private bool movimiento = true;

    void Update()
    {
        if (movimiento)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            if (transform.position.x >= 10.0f)
            {
                movimiento = false;
            }
        }
        else
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
            if (transform.position.x <= 0.0f)
            {
                movimiento = true;
            }
        }
    }
}