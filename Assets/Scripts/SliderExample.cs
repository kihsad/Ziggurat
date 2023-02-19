using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


namespace Ziggurat 
{

    public class SliderExample : MonoBehaviour
    {
        public Slider _slider;
        public TextMeshProUGUI _sliderText;


        void Update ()
        {
            _sliderText.text = _slider.value.ToString();
        }
    }


}



