using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BrightnessSlider : MonoBehaviour
{

    [SerializeField] private Slider _slider;
    public float value;

    public Light light1;
    public Light light2;
    public Light light3;
    public Light light4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(_slider.value);
        value = _slider.value;
        light1.intensity = _slider.value;
        light2.intensity = _slider.value;
        light3.intensity = _slider.value;
        light4.intensity = _slider.value;
    }
}
