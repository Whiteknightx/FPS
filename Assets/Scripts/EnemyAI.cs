using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    private NavMeshAgent _navMeshAgent;
    private Transform playerTransform;
    private Vector3 range;
    private Transform sp;
    public static Animator anim;

    private void Start()
    {
        sp = GameObject.FindGameObjectWithTag("spw").transform;
        _navMeshAgent = GetComponent<NavMeshAgent>();
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        //range = new Vector3(Random.Range(-5f, 5f), 0, Random.Range(-5f, 5f)); // set a random range for the enemy to follow the player
        range = new Vector3(7, transform.position.y, 7);
        anim = transform.GetComponent<Animator>();
    }

    private void FixedUpdate()
    
    {
        float distance = Vector3.Distance(transform.position, playerTransform.position);

        if (anim == null)
        {
            anim = GetComponentInChildren<Animator>();
        }
        if (distance <= range.magnitude)
        { // if the player is within the range
            _navMeshAgent.SetDestination(playerTransform.position);
            anim.SetBool("Run", true);
        }
        else
        { // if the player is outside the range
            _navMeshAgent.SetDestination(transform.position);
            anim.SetBool("Run", false);  
        }
    }
}
