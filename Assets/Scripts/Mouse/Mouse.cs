using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MousePointer
{
    public static GameObject CheckPickUpable(Vector3 startPosition, Transform direction, float range, LayerMask layer)
    {
        if (Physics.Raycast(startPosition, direction.forward * range, out RaycastHit hit, range, layer))
        {
            return hit.transform.gameObject;
        }
        else return null;
    }
    public static GameObject CheckPickUpable(Vector3 startPosition, Transform direction, float range)
    {
        if (Physics.Raycast(startPosition, direction.forward * range, out RaycastHit hit, range))
        {
            return hit.transform.gameObject;
        }
        else return null;
    }
}
