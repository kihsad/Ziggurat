using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ziggurat
{
    public class DamageController : MonoBehaviour
    {
        private int _health;
        private UnitData _data;
        void Start()
        {
            _health = _data.Health;
        }
        //public event Action OnDead;
        //public event Action<int, float> OnHealthChange;

        //private float _health;

        //public bool IsDead => _health <= 0;

        //public int MaxHealth => GetComponent<IHaveHealth>().MaxHealth;

        //public float Health
        //{
        //    get => _health;

        //    private set

        //    {
        //        _health = value;
        //        _health = Mathf.Clamp(value, 0, MaxHealth);
        //        OnHealthChange?.Invoke(MaxHealth, _health);

        //        if (_health <= 0)
        //        {
        //            OnDead?.Invoke();
        //            Destroy(gameObject);
        //        }
        //    }
        //}
        public void Kill()
        {
            _health = 0;
        }

        public void TakeDamage(int damage)
        {
            _health -= damage;
        }

        //private void OnEnable() => Restore();

        //public void Restore() => _health = MaxHealth;

    }
}
