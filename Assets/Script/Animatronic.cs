using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class Animatronic : MonoBehaviour
{
    public NavMeshAgent agent;
    public Animator animator;
    public Transform waypoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(waypoint.position);
    }
}
