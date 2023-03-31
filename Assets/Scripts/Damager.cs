
using UnityEngine;

namespace Ziggurat
{
    public class Damager: MonoBehaviour
    {

        private Animator _animator;

        public Transform _attackPoint;

        public float _attackRange = 0.5f;

        private Collider[] _targets = new Collider[100];

        public Health _health;


        public LayerMask _enemyLayer;

        private UnitData _unitData;

        public void Attack()
        {
            _animator.SetTrigger("isFastAttacking");
            //Physics.OverlapSphereNonAlloc(_attackPoint.position, _attackRange, _targets, _enemyLayer);

            //foreach 


            //OnTriggerEnter();

        }

      

        public void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out Health health))
            {
                health.TakeDamage(_unitData.LightDamage);
            }
        }


        void Start()
        {

            _health = GetComponent<Health>(); 
            _unitData = GetComponent<UnitData>();
        }


    }
}
