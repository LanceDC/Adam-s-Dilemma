using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PasswordCheck : MonoBehaviour
{
    public string password;
    public Text inputText;
    public GameObject passwordCheckObject;
    public GameObject emailObject;


    public void CheckPassword()
    {
        if(inputText.text == password)
        {
            passwordCheckObject.SetActive(!passwordCheckObject.activeSelf);
            emailObject.SetActive(!emailObject.activeSelf);
        }
    }
}
