using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrintPainting : MonoBehaviour
{
    private GameObject canvas;
    public Transform spawnPoint;

    public void PrintButton()
    {
        Destroy(canvas);
        canvas = null;

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

        if (canvas != null)
        {
            canvas = Instantiate(canvas, spawnPoint.position, spawnPoint.rotation);
            canvas.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        }
    }
}
