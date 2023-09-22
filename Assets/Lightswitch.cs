using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public Light light;
    private int colorIndex = 0;

    // Array of predefined colors to toggle/cycle through
    private Color[] colors = {
        Color.red,
        Color.yellow,
        Color.blue,
        Color.green,
        
       
    };

    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
        if (light == null)
        {
            Debug.LogError("No Light component found on this GameObject. Make sure this script is attached to a point light.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ToggleLightColor();
        }
    }

    void ToggleLightColor()
    {
        if (light != null)
        {           
            light.color = colors[colorIndex];
          
            colorIndex = (colorIndex + 1) % colors.Length;
        }
    }
}
