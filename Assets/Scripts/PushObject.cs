using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushObject : MonoBehaviour
{
    private Rigidbody _rigitB;
    
    // Start is called before the first frame update
    void Start()
    {
        _rigitB = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (CompareTag("Player"))
        {
            _rigitB.AddForce(Vector3.right,ForceMode.Impulse);
        }
    }
}
