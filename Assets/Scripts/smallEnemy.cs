using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class smallEnemy : MonoBehaviour
{
    [SerializeField] public Transform[] patrolP;
    NavMeshAgent myNavMeshAgent;
    public float changeDistance;
    int currentP = 0;
    public Transform _playerOn;
    public float radius = 2f;



    private void Awake()
    {
        myNavMeshAgent = GetComponent<NavMeshAgent>();
        GameObject player = GameObject.FindGameObjectWithTag("Player");

    }

    void Start()
    {
        
        myNavMeshAgent.destination = patrolP[0].position;
       
    }

    // Update is called once per frame
    void Update()
    {

        if (myNavMeshAgent.remainingDistance < changeDistance)
        {
            currentP++;
            if (currentP == patrolP.Length) currentP = 0;
            myNavMeshAgent.destination = patrolP[currentP].position;
        }

        
    }

    private void FixedUpdate()
    {
        float distance = Vector3.Distance(_playerOn.position, transform.position);
        if (distance <= radius)
        {
            myNavMeshAgent.SetDestination(_playerOn.position);
        }
        if (distance >= myNavMeshAgent.stoppingDistance)
        {
            myNavMeshAgent.destination = patrolP[currentP].position;
        }
    }
    }




