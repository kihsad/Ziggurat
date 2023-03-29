using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


namespace Ziggurat 
{
    public class SliderUIController : UnitCreator
    {
        public Slider _healthSlider;
        public TextMeshProUGUI _healthText;
        public Slider _speedSlider;
        public TextMeshProUGUI _speedText;
        public Slider _lightDamageSlider;
        public TextMeshProUGUI _lightDamageText;
        public Slider _heavyDamageSlider;
        public TextMeshProUGUI _heavyDamageText;
        public Slider _missingChanceSlider;
        public TextMeshProUGUI _missingChanceText;
        public Slider _criticalChanceSlider;
        public TextMeshProUGUI _criticalChanceText;

        public void ChangeHealthValue(int value)
        {
            //var healthValue = _healthSlider.value; 
            //_healthSlider.value = _health;
            //_healthText = healthValue.ToString();

            _healthText.text = _healthSlider.value.ToString();
        }

        public void ChangeSpeedValue(float value)
        {
            var speedValue = _speedSlider.value;
            _speedSlider.value = _moveSpeed;
            //_moveSpeed = _speedSlider.value;
        }

        public void ChangeLDValue(int value)
        {
            var lightDamageValue =
            _lightDamageSlider.value = _lightDamage;
        }

        public void ChangeHDValue(int value)
        {
            var heavyDamageValue = _heavyDamageSlider.value;
            _heavyDamageSlider.value = _heavyDamage;
        }

        public void ChangeMCValue(float value)
        {
            var missingChanceValue = _missingChanceSlider.value;
            _missingChanceSlider.value = _missingChance;
        }

        public void ChangeCCValue(float value)
        {
            var criticalChanceValue = _criticalChanceSlider.value;
            _criticalChanceSlider.value = _criticalChance;
        }


    }


}


