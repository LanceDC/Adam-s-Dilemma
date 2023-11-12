using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerInteract : MonoBehaviour, IInteractable
{
    public GameObject computerScreen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Interact()
    {
        GameManager.PausePlayer();
        computerScreen.SetActive(!computerScreen.activeSelf);
    }
}
