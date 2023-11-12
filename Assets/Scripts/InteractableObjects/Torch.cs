using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SelectionBase]
public class Torch : MonoBehaviour, IItemAction
{
    public GameObject torchLight;

    public void ItemAction()
    {
        torchLight.SetActive(!torchLight.activeSelf);
    }
}
