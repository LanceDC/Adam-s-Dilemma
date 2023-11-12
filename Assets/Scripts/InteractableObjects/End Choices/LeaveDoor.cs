using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaveDoor : MonoBehaviour, IInteractable
{
    public GameObject areYouSureMenu;

    [SerializeField] private GameObject button;

    public void Interact()
    {
        Leave();
    }

    public void Leave()
    {
        ChangeActive();
        GameManager.PausePlayer();
        ControllerHandler.SetCurrentSelectedButtonGlobal(button);
    }

    #region Leave Choice Buttons
    public void ChangeActive()
    {
        areYouSureMenu.SetActive(!areYouSureMenu.activeSelf);
    }

    public void ConfirmLeave()
    {
        GameManager.instance.GameOver(LastChoiceUsed.Leave);
    }
    #endregion
}
