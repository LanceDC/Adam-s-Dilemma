using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IUnlockable
{
    public bool isOpen = false;

    public Animator animator;


    public void Unlock()
    {
        isOpen = true;
        animator.SetBool("IsOpen", isOpen);
    }
   
}
