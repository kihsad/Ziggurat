
using UnityEngine;

namespace Ziggurat
{
    public class Damager: MonoBehaviour
    {

        private Animator _animator;
        
        private Transform _attackPoint;

        public float _attackRange = 10f;

        private Collider[] _targets = new Collider[100];

        private Health _health;

        public LayerMask _enemyLayer;

        public int Damage { get; set; }

        public void Attack()
        {
            Collider[] hitEnemies = Physics.OverlapSphere(_attackPoint.position, _attackRange, _enemyLayer);
            foreach (Collider enemy in hitEnemies)
            {
                enemy.GetComponent<Health>().TakeDamage(Damage);
            }
        }



        private void OnDrawGizmos()
        {
            Gizmos.color = Color.green;
            Gizmos.DrawWireSphere(_attackPoint.position, _attackRange);
        }

        void Start()
        {
            _attackPoint = GetComponentInChildren<AttackPoint>().transform;
            _health = GetComponent<Health>(); 
        }


    }
}
