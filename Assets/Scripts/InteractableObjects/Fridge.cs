using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fridge : MonoBehaviour, IInteractable
{

    private Lights lights;
    private OpenCabernets cabernets;

    void Start()
    {
        lights = GetComponent<Lights>();
        cabernets = GetComponent<OpenCabernets>();
    }

    public void Interact()
    {
        lights.Interact();
        cabernets.Interact();
    }

}
