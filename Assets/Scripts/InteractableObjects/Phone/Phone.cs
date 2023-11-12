using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phone : MonoBehaviour, IInteractable, IItemAction
{
    public Camera cam;
    public float range = 7f;

    private bool fistPickUp = false;

    [SerializeField] private AudioSource source;
    [SerializeField] private PhoneStand phoneStand;
    public void Interact()
    {
        PlayAudio();
    }

    public void ItemAction()
    {
        PlayerInteract interact = GetComponentInParent<PlayerInteract>();
        if(interact == null)
        {
            return;
        }

        GameObject obj = MousePointer.CheckPickUpable(cam.transform.position, cam.transform, range);
        if(obj != null)
        {
            PhoneStand stand = obj.GetComponent<PhoneStand>();
            if (stand != null)
            {
                interact.DropItem();
                transform.position = stand.phoneLocation.position;
                transform.rotation = stand.phoneLocation.rotation;
                transform.parent = null;
                source.Stop();
            }
        }
    }

    private void PlayAudio()
    {
        if (!fistPickUp)
        {
            //source.Play();
            phoneStand.pickedUpPhone = true;
            phoneStand.StopLightBeep();
            fistPickUp = true;
        }
    }
}
