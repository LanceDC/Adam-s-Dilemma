using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public SettingsData data;

    [SerializeField] private Slider sensitvitySlider;
    [SerializeField] private Toggle xToggle;
    [SerializeField] private Toggle yToggle;

    private void OnEnable()
    {
        SetPlayerStatsFromSettings();
    }

    public void SaveSettings()
    {
        if(PlayerController.instance != null)
        {
            PlayerController.SetPlayerSettings(data);
        }

        SaveSystem.SaveSettings(data);
    }

    public void InvertX(bool invert)
    {
        data.invertX = invert;
    }

    public void InvertY(bool invert)
    {
        data.invertY = invert;
    }

    public void CameraSensitvity(float sensitvity)
    {
        data.sensitvity = sensitvity;
    }

    private void SetPlayerStatsFromSettings()
    {
        if (SaveSystem.LoadSettings() != null)
            data = SaveSystem.LoadSettings();

        sensitvitySlider.value = data.sensitvity;
        xToggle.isOn = data.invertX;
        yToggle.isOn = data.invertY;
    }
}
