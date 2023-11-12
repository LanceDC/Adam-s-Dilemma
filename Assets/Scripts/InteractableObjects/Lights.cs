using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lights : MonoBehaviour, IInteractable
{
    //public GameObject lightToLight;
    public Light[] lights;
    public AudioSource source;

    private bool hasPower = false;

    public void Interact()
    {
        if (hasPower)
        {

            for (int i = 0; i < lights.Length; i++)
            {
                lights[i].enabled = !lights[i].enabled;
            }

            if(source != null)
                source.Play();
        }
    }

    public void PowerLights()
    {
        hasPower = !hasPower;
    }

    
}
