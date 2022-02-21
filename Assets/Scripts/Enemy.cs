using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int health;
    public Transform target;
    void FixedUpdate()
    {
        Vector3 Eposit = target.position - transform.position;
        transform.rotation = Quaternion.LookRotation(Eposit);
    }

   public void hurt(int _damage)
    {
        health -= _damage;

        if (health <= 0)
        {
            die();
        }
    }
    void die()
    {
        Destroy(gameObject);
    }
}
