using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MIneSpawner : MonoBehaviour
{
    [SerializeField] GameObject Mine;
    [SerializeField] Transform spawnerM;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Instantiate(Mine, spawnerM.position, spawnerM.rotation);
        }
    }
}
