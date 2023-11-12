using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverOverButton : MonoBehaviour
{
    public Light[] lights;

    public void ChangeLights()
    {
        for(int i = 0; i < lights.Length; i++)
        {
            lights[i].enabled = !lights[i].enabled;
        }
    }
}
