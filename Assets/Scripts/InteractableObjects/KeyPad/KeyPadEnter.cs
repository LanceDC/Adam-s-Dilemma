using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPadEnter : MonoBehaviour, IInteractable
{
    public Animator animator;

    private KeyPad keyPad;

    void Start()
    {
        keyPad = transform.parent.GetComponentInParent<KeyPad>();
    }

    public void Interact()
    {
        animator.SetTrigger("ButtonPressed");
        keyPad.Enter();
    }
}
