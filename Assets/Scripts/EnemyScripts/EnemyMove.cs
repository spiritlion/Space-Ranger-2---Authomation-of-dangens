using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public GameObject player;

    void Update()
    {
        transform.GetComponent<UnityEngine.AI.NavMeshAgent>().SetDestination(player.transform.position);
    }
}
