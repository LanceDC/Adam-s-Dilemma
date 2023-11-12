using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlIntrscutionMenu : MonoBehaviour
{
    public ControllerInstructionsImage[] instructionsImages;

    [SerializeField] private ControlImages[] controlImages;


    private void OnEnable()
    {
        SetInstructionImage();
    }

    private void SetInstructionImage()
    {
        int instructuionImagesIndex = 0;
        for(int i = 0; i < controlImages.Length; i++)
        {
            if(controlImages[i].controllerType == ControllerHandler.CurrentConnectedController)
            {
                instructionsImages[instructuionImagesIndex].instructionText.text = controlImages[i].imageName;
                instructionsImages[instructuionImagesIndex].instructionImage.sprite = controlImages[i].sprite;
                instructuionImagesIndex++;

                if(instructuionImagesIndex > instructionsImages.Length)
                {
                    return;
                }
            }
        }
    }
}

[System.Serializable]
public class ControllerInstructionsImage
{
    public Text instructionText;
    public Image instructionImage;
}
