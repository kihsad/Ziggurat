using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ChaseBehaviour : StateMachineBehaviour
{
    private NavMeshAgent _agent;
    private Transform _redKnight;
    private Transform _blueKnight;
    private Transform _greenKnight;
    private float _attackRange = 2;
    private float _chaseRange = 10;
    List<Transform> _enemies = new List<Transform>();

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        _agent = animator.GetComponent<NavMeshAgent>();
        _agent.speed = 4;

        _redKnight = FindObjectOfType<RedKnight>().transform;
        _blueKnight = FindObjectOfType<BlueKnight>().transform;
        _greenKnight = FindObjectOfType<GreenKnight>().transform;
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (this.GetComponent<RedKnight>())
        {
            _enemies.Add(_greenKnight);
            _enemies.Add(_blueKnight);
        }
        _agent.SetDestination(_enemies[0].position);
        private float distance = Vector3.Distance(_agent.transform.position, _enemies[0].position);
        //if (distance < attackRange)
        //    animator.SetBool("isAttacking", true);


        //if (distance > 10)
        //    animator.SetBool("isChasing", false);
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
