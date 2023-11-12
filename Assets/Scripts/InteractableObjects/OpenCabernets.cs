using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCabernets : MonoBehaviour, IInteractable
{
    public Animator animator;

    private bool isOpen = false;

    public void Interact()
    {
        isOpen = !isOpen;
        animator.SetBool("IsOpen", isOpen);
    }
}
