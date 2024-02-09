using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateSlider : MonoBehaviour
{
    public GameObject ObjectToRotate;

    public void RotateMyObject()
    {
        float sliderValue = GetComponent<Slider>().value;
        ObjectToRotate.transform.rotation = Quaternion.Euler(0, sliderValue * 360, 0);
    }
}
