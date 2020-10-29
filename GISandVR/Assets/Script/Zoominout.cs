using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zoominout : MonoBehaviour
{
    private Camera cam;
    private float startingFOV;

    public float minFOV;
    public float maxFOV;
    public float zoomRate;

    private float currentFOV;

    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
        startingFOV = cam.fieldOfView;
    }

    // Update is called once per frame
    void Update()
    {
        currentFOV = cam.fieldOfView;
        if (Input.GetKeyDown(KeyCode.P))
        {
            currentFOV = startingFOV;
        }

        if (Input.GetKey(KeyCode.I))
        {
            currentFOV -= zoomRate;
        }

        if (Input.GetKey(KeyCode.O))
        {
            currentFOV += zoomRate;
        }

        currentFOV = Mathf.Clamp(currentFOV, minFOV, maxFOV);
        cam.fieldOfView = currentFOV;
    }
}
