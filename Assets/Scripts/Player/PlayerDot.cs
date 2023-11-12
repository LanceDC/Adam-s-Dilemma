using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerDot : MonoBehaviour
{
    public Color normalColour;
    public Color interactColour;

    private bool lookinAtInteract;

    [SerializeField] private Image dot;
    [SerializeField] private Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        dot.color = normalColour;
    }

    // Update is called once per frame
    void Update()
    {
        if(DetectInteract())
        {
            dot.color = interactColour;
        }
        else
        {
            dot.color = normalColour;
        }
    }

    private bool DetectInteract()
    {
        RaycastHit hit;

        Physics.Raycast(cam.transform.position, cam.transform.forward * 7f, out hit, 7f);
        if (hit.collider != null)
        {
            IInteractable interactable = hit.collider.GetComponent<IInteractable>();
            IItemAction action = hit.collider.GetComponent<IItemAction>();
            if (interactable != null || action != null)
                return true;
            else
                return false;
            //return interactable != null || action != null;

        }
        else return false;


    }
}
