using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioB8 : MonoBehaviour
{
    public GameObject cubo;
    void OnMouseDown()
    {
        Invoke("destruirCubo", 2);
    }
    
    void destruirCubo()
    {
        Destroy(cubo);
    }
}