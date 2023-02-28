﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PatrolBehaviour : StateMachineBehaviour
{
    float timer;
    Transform point;
    NavMeshAgent agent;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        timer = 0;
        Transform pointObject = FindObjectOfType<Point>().transform;

        agent = animator.GetComponent<NavMeshAgent>();
        agent.SetDestination(point.position);

    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //if (agent.remainingDistance <= agent.stoppingDistance)
         //   agent.SetDestination(points[Random.Range(0, points.Count)].position);

        /* timer += Time.deltaTime;
         if (timer > 1)
             animator.SetBool("isPatrolling", false);
        */
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //agent.SetDestination(agent.transform.position);
    }


}