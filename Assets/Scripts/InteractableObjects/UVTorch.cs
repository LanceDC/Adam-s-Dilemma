using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SelectionBase]
public class UVTorch : Torch
{
    private readonly float revealRange = 10f;

    [SerializeField] private Transform revealTransform;
    [SerializeField] private Color lightColour;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RevealLoaction();
    }

    private void RevealLoaction()
    {
        revealTransform.gameObject.SetActive(torchLight.activeSelf);

        RaycastHit hit;

        Physics.Raycast(torchLight.transform.position, torchLight.transform.forward * revealRange, out hit, revealRange);
        revealTransform.position = hit.point;

    }
}
