using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class SliderScripts : MonoBehaviour
{
    public OverallManager ovrMan;
    public Slider slider;
    public Image fill;

    float fillValue;

    private void Start()
    {
        fillValue = ovrMan.cloakLevel / 30.0f;
        FillSlider();
    }

    public void Update()
    {
        fillValue = ovrMan.cloakLevel / 30.0f;
        FillSlider();
        //fill.fillAmount = fillValue;
    }
    public void FillSlider()
    {
        fill.fillAmount = fillValue; //slider.value;
    }
}
