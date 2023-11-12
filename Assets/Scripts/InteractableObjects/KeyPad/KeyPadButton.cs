using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPadButton : MonoBehaviour, IInteractable
{
    public int keypadNumber;
    public Animator animator;

    private KeyPad pad;

    void Start()
    {
        pad = transform.parent.GetComponentInParent<KeyPad>(); 
    }

    public void Interact()
    {
        //When interacted, add this keypad buttons' number to the entered code
        pad.EnterNumber(keypadNumber);

        animator.SetTrigger("ButtonPressed");
    }
}
