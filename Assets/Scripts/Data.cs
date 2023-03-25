using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ziggurat
{
    public class Data : MonoBehaviour
    {
        //[SerializeField]
        private UnitCreator _unitCreator;
        public float _moveSpeed;
        public int _health;
        public int _lightDamage;
        public int _heavyDamage;
        public float _missingChance;
        public float _criticalChance;
        void Start()
        {
            _unitCreator = GetComponent<UnitCreator>();
            _moveSpeed = _unitCreator._moveSpeed;
            _health = _unitCreator._health;
            _lightDamage = _unitCreator._lightDamage;
            _heavyDamage = _unitCreator._heavyDamage;
            _missingChance = _unitCreator._missingChance;
            _criticalChance = _unitCreator._criticalChance;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}