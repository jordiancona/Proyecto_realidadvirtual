
// Proyecto para Realidad virtual
// Pelota

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelota : MonoBehaviour
{
    public Transform Position;
    private GameObject balon;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "balon")
        {
            ball = other.GetComponent<GameObject>();
            Respawn();
        }
    }
}