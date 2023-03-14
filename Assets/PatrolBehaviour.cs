using UnityEngine;
using UnityEngine.AI;

public class PatrolBehaviour : StateMachineBehaviour
{
    private float _timer;
    private Transform _point;
    private NavMeshAgent _agent;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        _timer = 0;
        _point = FindObjectOfType<Point>().transform;
        _agent = animator.GetComponent<NavMeshAgent>();
        _agent.SetDestination(_point.position);

    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //if (agent.remainingDistance <= agent.stoppingDistance)
         //   agent.SetDestination(points[Random.Range(0, points.Count)].position);

        /* timer += Time.deltaTime;
         if (timer > 1)
             animator.SetBool("isPatrolling", false);
        */
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //agent.SetDestination(agent.transform.position);
    }


}