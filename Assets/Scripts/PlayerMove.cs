using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float speedP;
    [SerializeField] public float speedR;
    [SerializeField] private Vector3 direction;
    [SerializeField] private float thrust;
    public bool hasKey = false;

    

    private Rigidbody rb;
    private CapsuleCollider _collider;

    Quaternion p_Rot;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        _collider = GetComponent<CapsuleCollider>();
        rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
        
    }
    
    private void FixedUpdate()
    {
        dir();
        Movement();
        Jump();
    }

    void dir()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");
        direction.Set(direction.x, 0f, direction.z);
        var _speed = direction * speedP * Time.fixedDeltaTime;
        transform.Translate(_speed);

        Vector3 desiredForward = Vector3.RotateTowards(transform.forward, direction, speedR * Time.deltaTime, 0f);
        p_Rot = Quaternion.LookRotation(desiredForward);

    }

    private void Movement()
    {
        rb.MovePosition(rb.position + direction * Time.deltaTime);
        rb.MoveRotation(p_Rot);
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * thrust,ForceMode.VelocityChange);
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        
        if(gameObject.name=="ClosedDoor"&& hasKey == true)
        {
            gameObject.GetComponentInChildren<Animator>().SetTrigger("ClosedDoor");
        }
    }

}
