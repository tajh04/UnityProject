using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class resultData : MonoBehaviour
{
    public Text UserNameBox;
    public Text Win;
    public Text Lose;
    public Text Tie;

    void Start()
    {
        UserNameBox.text = PlayerPrefs.GetString("username");
        Win.text = PlayerPrefs.GetString("win");
        Lose.text = PlayerPrefs.GetString("lose");
        Tie.text = PlayerPrefs.GetString("tie");
    }

}
