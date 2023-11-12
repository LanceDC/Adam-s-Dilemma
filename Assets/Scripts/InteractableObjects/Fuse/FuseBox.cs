using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuseBox : ObjectToUnlock
{
    private bool isOn = false;
    [SerializeField] private MeshRenderer fuseRenderer;
    [SerializeField] private Material offMaterial;
    [SerializeField] private Material onMaterial;

    public override void PlaceItem(GameObject obj)
    {
        fuseRenderer.material = isOn ? onMaterial : offMaterial;
        base.PlaceItem(obj);
    }
}
