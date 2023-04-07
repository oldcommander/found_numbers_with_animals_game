using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WelcomeScript : MonoBehaviour
{
    public static string name;
    public TMP_InputField nameInput;
    public GameObject welcomePanel;

    public void ClickButton()
    {
        name = nameInput.text;
        welcomePanel.SetActive(false);
    }
}
