using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TrailPaintRot : MonoBehaviour
{
    private TrailRenderer trailRenderer;
    private GameObject canvas;

    void Start()
    {
        trailRenderer = GetComponent<TrailRenderer>();

        if (GameObject.Find("Cube(Clone)") != null)
        {
            canvas = GameObject.Find("Cube(Clone)");
        }
        if (GameObject.Find("Plane(Clone)") != null)
        {
            canvas = GameObject.Find("Plane(Clone)");
        }
        if (GameObject.Find("Sphere(Clone)") != null)
        {
            canvas = GameObject.Find("Sphere(Clone)");
        }
    }

    void Update()
    {
        if(transform.parent == null)
        {
            transform.SetParent(canvas.transform, true);
        }
    }
}
