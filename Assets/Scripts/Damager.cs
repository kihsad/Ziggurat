﻿
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

        private UnitData _unitData;

        public void Attack()
        {
            for (int i = 0; i < Physics.OverlapSphereNonAlloc(_attackPoint.position, _attackRange, _targets, _enemyLayer); i++)
            {
                Debug.Log("hit");
            }

        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.green;
            Gizmos.DrawWireSphere(_attackPoint.position, _attackRange);
        }



        //public void OnTriggerEnter(Collider other)
        //{
        //    if (other.TryGetComponent(out Health health))
        //    {
        //        health.TakeDamage(_unitData.LightDamage);
        //        Debug.Log("hit");
        //    }
        //}


        void Start()
        {
            _attackPoint = FindObjectOfType<AttackPoint>().transform;
            _health = GetComponent<Health>(); 
            _unitData = GetComponent<UnitData>();
        }


    }
}
