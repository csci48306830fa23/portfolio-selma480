using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    public Slider slider;
    float scale;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        scale = slider.value * 150; // puts the value from the slider into scale 
        Vector3 v = new Vector3(scale, scale, scale);
        transform.localScale = v;

    }
}
