using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioB10 : MonoBehaviour
{
    public GameObject targetCube;
    private int contador = 0;

    void OnMouseDown()
    {
        contador++;
        targetCube.name = "Clicks: " + contador;
    }
}