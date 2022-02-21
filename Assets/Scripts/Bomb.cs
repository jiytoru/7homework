using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
   [SerializeField] private int _damage;
    
    private Rigidbody rbg;

    void Start()
    {
        rbg = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            var enemy = other.GetComponent<Enemy>();
            enemy.hurt(_damage);
            Destroy(gameObject);
        }
    }
}
