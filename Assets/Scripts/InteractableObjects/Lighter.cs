using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighter : MonoBehaviour, IItemAction
{
    //FireBarrel
    public Camera cam;
    public float range;
    public FireBarrel barrel;
    public SphereCollider sphere;

    public void ItemAction()
    {
        GameObject obj = MousePointer.CheckPickUpable(cam.transform.position, cam.transform, range);
        if (obj != null)
        {
            if(obj.CompareTag("FireBarrel"))
            {
                barrel.enabled = true;
                barrel.ActivateFireBarrel();
            }
            
            if(obj.CompareTag("Fire/Candel"))
            {
                obj.GetComponentInChildren<Light>().enabled = true;
            }
        }
    }
}
