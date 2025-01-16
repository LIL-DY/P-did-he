using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Lighter : MonoBehaviour
{
    Light2D myLight;

    // Update is called once per frame
    private void Start()
    {
        myLight = GetComponent<Light2D>();
    }
    void Update()
    {
        bool On;
        if(Input.GetKeyDown(KeyCode.E))
        {
            myLight.enabled = !myLight.enabled;
        }
        if (myLight.enabled = !myLight.enabled)
        {
            On = true;
        }

    }


}
