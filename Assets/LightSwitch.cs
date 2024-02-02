using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.OpenXR.Input;

public class LightSwitch : MonoBehaviour
{
    public Light light;
    public InputActionReference action;

    private bool toggled;
    
    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
        action.action.Enable();
        action.action.performed += ctx => { toggleLightColor(); };
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("tab"))
        {
            toggleLightColor();
        }
    }
    
    private void toggleLightColor()
    {
        if (!toggled)
        {
            light.color = Color.blue;
            toggled = true;
        }
        else
        {
            light.color = Color.white;
            toggled = false;
        }
    }
}
