using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public Text nameText;
    public Image image;

    private int currentControlSettingShowing = 0;

    [SerializeField] private ControlImages[] controlImages;

    private void Start()
    {
        nameText.text = controlImages[currentControlSettingShowing].imageName;
        image.sprite = controlImages[currentControlSettingShowing].sprite;
    }

    public void NextControlImage(int val)
    {
        currentControlSettingShowing += val;

        if (currentControlSettingShowing < 0)
        {
            currentControlSettingShowing = controlImages.Length - 1;
        }

        currentControlSettingShowing %= controlImages.Length;

        nameText.text = controlImages[currentControlSettingShowing].imageName;
        image.sprite = controlImages[currentControlSettingShowing].sprite;
    }

}


[System.Serializable]
public class ControlImages
{
    public ControllerType controllerType;
    public string imageName;
    public Sprite sprite;
}