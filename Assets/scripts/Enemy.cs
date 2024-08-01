using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyFollow : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform target;

    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (target != null) // if this target has a target to follow...
        {
            agent.SetDestination(target.position); // Set that target's current position as this enemy's destination
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) // If the object this enemy just hit is the player...
        {
            // Despawn the player, and tell the GameManger to Reset the current level
            print("Game Over");
            Destroy(other.gameObject);
           // GameManager.Instance.GameOver();
        }
    }
}
