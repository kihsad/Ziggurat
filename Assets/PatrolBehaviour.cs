using UnityEngine;
using UnityEngine.AI;

public class PatrolBehaviour : StateMachineBehaviour
{
    private Transform _point;
    private NavMeshAgent _agent;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        _point = FindObjectOfType<Point>().transform;
        _agent = animator.GetComponent<NavMeshAgent>();
        _agent.SetDestination(_point.position);

    }
}