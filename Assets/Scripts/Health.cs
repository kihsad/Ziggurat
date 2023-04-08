﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Ziggurat
{
    public class Health : MonoBehaviour
    {
        private int _value;

        public int Value
        {
            get => _value;
            set
            {
                _value = Mathf.Clamp(value, 0, 50);
                if (_value <= 0)
                {
                    Destroy(gameObject);


                }
            }
        }

        public void Restore()
        {
            Value = 50;
        }

        public void TakeDamage(int damage)
        {
            Value -= damage;
            
            Debug.Log(Value + name);
        }

        public void Die()
        {
            Value = 0;
        }

    }
}
