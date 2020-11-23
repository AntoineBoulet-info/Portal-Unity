using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.CodeDom.Compiler;
using UnityEngine.SceneManagement;


public class DialogText : MonoBehaviour
{
    
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    public GameObject continueButton;
    public int Scene;


    void Start()
    {
        StartCoroutine(Type());
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    void Update()
    {
        if(textDisplay.text == sentences[index])
        {
            continueButton.SetActive(true); //Enabled the button Continue 
        }
    }

    IEnumerator Type()
    {
        foreach(char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);

        }
    }

    public void NextSentence()   // this fucntion triggered the continue button 
    {
        continueButton.SetActive(false); // Disabled the button Continue

        if(index < sentences.Length - 1) //  checked that the length of the sentences are upper than the index returned
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        } else
        {
            textDisplay.text = "";
            continueButton.SetActive(false);
        }
        if(index == sentences.Length - 1)
        {
            SceneManager.LoadScene(Scene);
        }
    }

}
