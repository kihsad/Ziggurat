
using System;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;
using Ziggurat;

namespace Ziggurat
{
    public class StatPanel: MonoBehaviour
    {
        [SerializeField] private Slider _speedSlider, _healthSlider, _lightDamageSlider, 
            _heavyDamageSlider, _missingChanceSlider, _critDamageSlider;

        private UnitData _unitData = new UnitData();

        [SerializeField] private Button _creationButton;

        [SerializeField] private UnitCreator _unitCreator;

        private void OnEnable()
        {
            _creationButton.onClick.AddListener(Create);
        }

        private void Create()
        {
            _unitData.MoveSpeed = _speedSlider.value;
            _unitData.Health = (int)_healthSlider.value;
            _unitData.LightDamage = (int)_lightDamageSlider.value;
            _unitData.HeavyDamage = (int)_heavyDamageSlider.value;
            _unitData.MissingChance = (int)_missingChanceSlider.value;
            _unitData.СriticalChance = (int)_critDamageSlider.value;

            _unitCreator.InstantiateKnightUnit(_unitData);
        }

        private void OnDisable()
        {
            _creationButton.onClick.RemoveListener(Create);
        }

        

    }
}
