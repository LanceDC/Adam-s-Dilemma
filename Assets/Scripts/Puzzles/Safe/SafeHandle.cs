using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeHandle : MonoBehaviour, IUnlockable, IInteractable
{
    public Animator animator;
    private bool safeIsUnlocked = false;
    public void Interact()
    {
        if(safeIsUnlocked)
        {
            animator.SetTrigger("OpenSafeDoor");
        }
    }

    public void Unlock()
    {
        safeIsUnlocked = true;
    }


}
