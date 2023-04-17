using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    
    [SerializeField] private Slider _slider;
    [SerializeField] private Slider _hueSlider;
    public float value;

    public Light light1;
    public Light light2;
    public Light light3;
    
    float H1, S1, V1;
    float H2, S2, V2;
    float H3, S3, V3;
    // Start is called before the first frame update
    void Start()
    {
        Color.RGBToHSV(light1.color, out H1, out S1, out V1);
        Color.RGBToHSV(light2.color, out H2, out S2, out V2);
        Color.RGBToHSV(light2.color, out H3, out S3, out V3);
        
        _hueSlider.onValueChanged.AddListener(delegate {ValueChangeCheck(); });
    }

    public void ValueChangeCheck()
    {
        light1.color = Color.HSVToRGB(_hueSlider.value, S1, V1);
        light2.color = Color.HSVToRGB(_hueSlider.value, S2, V2);
        light3.color = Color.HSVToRGB(_hueSlider.value, S3, V3);
    }

    // Update is called once per frame
    void Update()
    {
        
     
        light1.intensity = _slider.value;
        light2.intensity = _slider.value;
        light3.intensity = _slider.value;

     //   light1.color = Color.HSVToRGB(_hueSlider.value, 100, 100);
    //   light2.color = Color.HSVToRGB(_hueSlider.value, 100, 100);
    //    light3.color = Color.HSVToRGB(_hueSlider.value, 100, 100);
   // Color.RGBToHSV(light1.color, out H1, out S1, out V1);
     Debug.Log(H1);
    // Debug.Log("hue : "+_hueSlider.value);
    }

    public void testingShown()
    {
        Debug.Log("Show");
    }
    
    public void testingHide()
    {
        Debug.Log("Hide");
    }
}
