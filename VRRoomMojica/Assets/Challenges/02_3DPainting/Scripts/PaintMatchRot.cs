using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintMatchRot : MonoBehaviour
{
    public GameObject arrow1;
    public GameObject arrow2;
    public TrailRenderer trailRenderer;


    void Update()
    {
        arrow1 = GameObject.Find("Pedestal");
        arrow2.transform.rotation = arrow1.transform.rotation;
    }
}
