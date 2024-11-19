using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioB3 : MonoBehaviour
{
    public float scalingSpeed = 1.0f;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            transform.localScale += Vector3.one * scalingSpeed * Time.deltaTime;
        }
        else
        {
            transform.localScale -= Vector3.one * scalingSpeed * Time.deltaTime;
            transform.localScale = new Vector3(
                Mathf.Max(1, transform.localScale.x),
                Mathf.Max(1, transform.localScale.y),
                Mathf.Max(1, transform.localScale.z)
            );
        }
    }
}