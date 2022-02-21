using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObjects : MonoBehaviour
{
    public GameObject keys;
    

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PickUpObjects.Destroy(keys);
        }
    }

    
}
