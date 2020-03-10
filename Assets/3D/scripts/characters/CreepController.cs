using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class CreepController : MonoBehaviour
{
    NavMeshAgent agent;
   public GameObject finalTarget;
     void Awake()
    {
        agent = GetComponent < NavMeshAgent > ();
    }    

    void start()
    {
        if (finalTarget != null)
        {
            agent.SetDestination(finalTarget.transform.position);
        }
    }
}
