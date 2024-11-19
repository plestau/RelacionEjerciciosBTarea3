using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioB9 : MonoBehaviour
{
    public GameObject cubo;
    void OnMouseDown()
    {
        float delay = Random.Range(3.0f, 5.0f);
        Invoke("desactivarCubo", delay);
    }
    
    void desactivarCubo()
    {
        cubo.SetActive(false);
    }
}