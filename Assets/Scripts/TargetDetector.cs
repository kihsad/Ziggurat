using UnityEngine.AI;
using UnityEngine;

public class TargetDetector : MonoBehaviour
{
    [SerializeField]
    private LayerMask _layerMask;
    [SerializeField, Range(0, 100)] 
    private float _distance;
    private Knight _target;
    private NavMeshAgent _agent;
    private Collider[] _targets = new Collider[100];
    private float _stoppingDistance = 2;

    //public float stoppingDistance
    //{
    //    get => _stoppingDistance;
    //    set
    //    {
    //        _stoppingDistance = value;
    //    }
    //}

    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    public void Detect()
    {
        for (int i=0; i<Physics.OverlapSphereNonAlloc(transform.position, _distance, _targets, _layerMask); i++)
        {
            _agent.SetDestination(_targets[0].ClosestPoint(transform.position));
            _distance = Vector3.Distance(_agent.transform.position, _targets[0].ClosestPoint(transform.position));
            if (_distance <= _stoppingDistance)
            {
                //AttackBehaviour.OnStateEnter(_agent, _target, _layerMask);
            }
        }
    }

    private void FixedUpdate()
    {
        Detect();
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, _distance);
    }
}
