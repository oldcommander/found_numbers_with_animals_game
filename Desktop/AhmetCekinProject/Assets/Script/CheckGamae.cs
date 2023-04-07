using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class CheckGamae : MonoBehaviour
{
    public int birdCount;
    public int fishCount;
    public int butterFlyCount;
    public int frogCount;
    public TMP_InputField fieldBird, fieldFish, fieldButterfly, fieldFrog; 
    public static CheckGamae Instance;
    public TextMeshProUGUI trueInput;
    public GameObject truePanel;
    public TextMeshProUGUI agaim;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    private void Start()
    {
        Check();
    }

    public void Check()
    {
        for (int i = 0; i < GameController.Instance.prefabObjects.Count; i++)
        {
            if (GameController.Instance.prefabObjects[i].tag == "bird")
            {
                birdCount +=  GameController.Instance.prefabObjects[i].GetComponent<Value>().valueCount;
            }
            if (GameController.Instance.prefabObjects[i].tag == "fish")
            {
                fishCount += GameController.Instance.prefabObjects[i].GetComponent<Value>().valueCount;
            }
            if (GameController.Instance.prefabObjects[i].tag == "butterfly")
            {
                butterFlyCount += GameController.Instance.prefabObjects[i].GetComponent<Value>().valueCount;
            }
            if (GameController.Instance.prefabObjects[i].tag == "frog")
            {
                frogCount += GameController.Instance.prefabObjects[i].GetComponent<Value>().valueCount;
            }
        }
    }

    public void ClickButton()
    {
        if (birdCount == int.Parse(fieldBird.text) && fishCount == int.Parse(fieldFish.text) && butterFlyCount == int.Parse(fieldButterfly.text) && frogCount == int.Parse(fieldFrog.text))
        {
            trueInput.text = "Tebrikler!"  + " "+ WelcomeScript.name;
            truePanel.SetActive(true);
        }
        else
        {
            fieldBird.text = string.Empty; fieldButterfly.text = string.Empty; fieldFish.text = string.Empty; fieldFrog.text = string.Empty;
            agaim.text = "Tekrar Deneyiniz !";
            StartCoroutine(again());
        }
    }

    IEnumerator again()
    {
        yield return new WaitForSeconds(1f);
        agaim.text = "";
    }

    public void AgainGame()
    {
        SceneManager.LoadScene(0);        
    }
}
