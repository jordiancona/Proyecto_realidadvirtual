
// Lanzar Balón

using System
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanzadorBalon : MonoBehaviour
{
    public GameObject balon;
    public Transform puntoLanzamiento;
    public float fuerzaLanzamiento = 10f;

    public void LanzarBalon()
    {
        GameObject balonLanzado = Instantiate(balon, puntoLanzamiento.position, puntoLanzamiento.rotation);
        Rigidbody rb = balonLanzado.GetComponent<Rigidbody>();
        if (rb == null)
        {
            rb.AddForce(puntoLanzamiento.forward * fuerzaLanzamiento, ForceMode.Impulse);
        }
    }
}