using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.AI;

namespace Ziggurat
{
    public class PatrolBehaviour : StateMachineBehaviour
    {
        private Transform _point;
        private NavMeshAgent _agent;
        private UnitData _data;
        public float MoveSpeed { get; set; }

        override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            _point = FindObjectOfType<Point>().transform;
            _agent = animator.GetComponent<NavMeshAgent>();
            //_agent.speed = _data._moveSpeed;
            _agent.speed = MoveSpeed;
            _agent.SetDestination(_point.position);

                        
        }
    }
}