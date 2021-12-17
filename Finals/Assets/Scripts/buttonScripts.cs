using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class buttonScripts : MonoBehaviour
{
    public Text winText;
    public Text loseText;
    public Text tieText;

    public void clickBack()
    {
        SceneManager.LoadScene("firstScene");
    }

    public void clickEnd()
    {
        
        PlayerPrefs.SetString("win", winText.text);
        PlayerPrefs.SetString("lose", loseText.text);
        PlayerPrefs.SetString("tie", tieText.text);

        SceneManager.LoadScene("endScene");
    }


}
