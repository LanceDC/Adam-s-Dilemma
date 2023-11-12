using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeyPad : MonoBehaviour
{
    public int[] passCode;
    public UnlockObjects unlockObjects;
    public TMP_Text meshPro;

    [SerializeField] private int[] codeEntered;
    private int currentNumberEntered = 0;
    private bool keyPadUnlocked = false;

    [SerializeField] private AudioSource buttonPressSource;
    [SerializeField] private AudioSource wrongCodeSource;
    [SerializeField] private AudioSource correctCodeSource;


    void Start()
    {
        codeEntered = new int[passCode.Length];
        UpdateText();
    }

    //Changes the next number for the entered code to be the number pressed on the keypad
    public void EnterNumber(int number)
    {
        if (!keyPadUnlocked && currentNumberEntered < passCode.Length)
        {
            codeEntered[currentNumberEntered] = number;
            currentNumberEntered++;
            UpdateText();
        }
    }

    //Sets the code entered to be all 0
    public void Clear()
    {
        for(int i = 0; i < codeEntered.Length; i++)
        {
            codeEntered[i] = 0;
        }
        currentNumberEntered = 0;
        UpdateText();
    }

    public void Enter()
    {
        bool correctAnswer = false;

        for(int i = 0; i < passCode.Length; i++)
        {
            //Checks to see if the code entered, matches the code needed to unlock keypad
            if (passCode[i] == codeEntered[i])
            {
                correctAnswer = true;
            }
            else
            {
                correctAnswer = false;
                break;
            }
        }

        if (correctAnswer)
        {
            //Call of of the functions that have been set in the inspector
            unlockObjects.Unlock?.Invoke();
            keyPadUnlocked = true;
        }
        else
        {
            Clear();
        }
    }


    //Updates the text on the keypad to what ever the code entered is
    private void UpdateText()
    {
        meshPro.text = "";
        for (int i = 0; i < codeEntered.Length; i++)
        {
            meshPro.text += $"{codeEntered[i]}";
        }
    }
}
