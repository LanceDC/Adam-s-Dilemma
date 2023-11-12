using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPadClear : MonoBehaviour, IInteractable
{
    public Animator animator;

    private KeyPad keyPad;

    void Start()
    {
        keyPad = transform.parent.GetComponentInParent<KeyPad>();
    }

    public void Interact()
    {
        keyPad.Clear();
        animator.SetTrigger("ButtonPressed");
    }
}
