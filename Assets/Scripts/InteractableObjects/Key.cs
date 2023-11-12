using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour, IItemAction
{
    public Camera cam;
    public float range;

    public void ItemAction()
    {
        GameObject obj = MousePointer.CheckPickUpable(cam.transform.position, transform, range);
        if (obj != null)
        {
            ObjectToUnlock toUnlock = obj.GetComponent<ObjectToUnlock>();
            if (toUnlock != null)
            {

                //Remove the object from the player
                PlayerInteract interact = GetComponentInParent<PlayerInteract>();
                interact.DropItem();

                toUnlock.PlaceItem(gameObject);
            }
        }


    }
}
