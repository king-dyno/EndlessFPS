using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

/* Donovan and Ben
 * 4/28/2025
 * handles the enemy movement
 */

public class EnemyMovement : MonoBehaviour
{
    public NavMeshAgent agent;

    public Transform player;

    public LayerMask whatIsGround, whatIsPlayer, whatIsPillar;

    public float sightRange;
    public bool playerInSightRange;

    private void Awake()
    {
        player = GameObject.Find("Player").transform;
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);
        if (playerInSightRange) ChasePlayer();
        
    }

    private void ChasePlayer() 
    {
      agent.SetDestination(player.position);
    
    }

    private void OnCollisionEnter(Collision collision)
    {
        //check if colliding object was the player
        if (collision.gameObject.GetComponent<FPSController>())
        {
            collision.gameObject.GetComponent<FPSController>().Loselife();
        }
    }

   


}
