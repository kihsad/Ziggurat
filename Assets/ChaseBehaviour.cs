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


    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        _agent = animator.GetComponent<NavMeshAgent>();
        _agent.speed = 4;


    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //void CheckCollider(Vector3 center, float radius)
        //{
        //    int maxColliders = 10;
        //    Collider[] hitColliders = new Collider[maxColliders];
        //    int numColliders = Physics.OverlapSphereNonAlloc(center, radius, hitColliders);
        //    for (int i = 0; i < numColliders; i++)
        //    {
        //        if (hitColliders[i] is _enemies)
        //            {
        //            _agent.SetDestination(_enemies[0].position);
        //            }
        //        //hitColliders[i].SendMessage("AddDamage");
        //    }
        //}

        //if (this.GetComponent<RedKnight>())
        //{
        //    _enemies.Add(_greenKnight);
        //    _enemies.Add(_blueKnight);
        //}
        //_agent.SetDestination(_enemies[0].position);
        //private float distance = Vector3.Distance(_agent.transform.position, _enemies[0].position);
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
