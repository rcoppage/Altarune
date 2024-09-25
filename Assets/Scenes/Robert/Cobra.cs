using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Cobra : MonoBehaviour
{
    [SerializeField] private Transform player; // Acesses player location
    [SerializeField] private NavMeshAgent agent; //Navigation for cobra enemy
    [SerializeField] private Collider colliderComponent; // Renamed to avoid conflict

    // Start is called before the first frame update
    void Start()
    {
        FollowPlayer();
       // agent.SetDestination(GetPositionCollider());
    }

    // Update is called once per frame
    void Update()
    {
        FollowPlayer();
    }
    

    // Sets spawn to random position x, y, z
    private Vector3 GetPositionCollider()
    {
        Bounds bounds = colliderComponent.bounds;

        Vector3 randomPosition = new Vector3(
            Random.Range(bounds.min.x, bounds.max.x),
            Random.Range(bounds.min.y, bounds.max.y),
            Random.Range(bounds.min.z, bounds.max.z)
        );

        return randomPosition;
    }

    //Makes Object follow player
    public void FollowPlayer()
    {
        agent.autoBraking = true;
        agent.SetDestination(player.position);
    }
}