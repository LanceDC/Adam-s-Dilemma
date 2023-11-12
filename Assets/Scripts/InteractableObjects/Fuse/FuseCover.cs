using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuseCover : MonoBehaviour, IInteractable
{
    [SerializeField] private BoxCollider box;
    [SerializeField] private OpenCabernets fuseBoxAnimation;


    public void Interact()
    {
        //Either enable or disable the box collider that is used to put the fuse in
        //so if the cover is closed, you cannot put the fuse in the fuse box
        box.enabled = !box.enabled;
        fuseBoxAnimation.Interact();
    }
}
