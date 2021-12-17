using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public Text Result;
    public Text winRes;
    public Text loseRes;
    public Text tieRes;
    public Image AIChoice;

    public string[] Choices;
    public Sprite Rock, Paper, Scissors;

    int w = 0;
    int l = 0;
    int t = 0;

    public void Play(string myChoice)
    {
        string randomChoice = Choices[Random.Range(0, Choices.Length)];

        if (randomChoice == "Paper")
        {
            if (myChoice == "Rock")
            {
                Result.text = "YOU LOSE!";
                l++;
            }
            else if (myChoice == "Scissors")
            {
                Result.text = "YOU WIN!";
                w++;
            }
            else
            {
                Result.text = "TIE!";
                t++;
            }

            AIChoice.sprite = Paper;
            winRes.text = " " + w;
            loseRes.text = " " + l;
            tieRes.text = " " + t;
        }
        else if (randomChoice == "Scissors") 
        {
            if (myChoice == "Paper")
            {
                Result.text = "YOU LOSE!";
                l++;
            }
            else if (myChoice == "Rock")
            {
                Result.text = "YOU WIN!";
                w++;
            }
            else
            {
                Result.text = "TIE!";
                t++;
            }

            AIChoice.sprite = Scissors;
            winRes.text = " " + w;
            loseRes.text = " " + l;
            tieRes.text = " " + t;

        }

        else if (randomChoice == "Rock")
        {
            if (myChoice == "Paper")
            {
                Result.text = "YOU WIN!";
                w++;
            }
            else if (myChoice == "Scissors")
            {
                Result.text = "YOU LOSE!";
                l++;
            }
            else
            {
                Result.text = "TIE!";
                t++;
            }

            AIChoice.sprite = Rock;
            winRes.text = " " + w;
            loseRes.text = " " + l;
            tieRes.text = " " + t;

        }

        /*switch (randomChoice)
        {
            case "Rock":
                switch (myChoice)
                {
                    case "Rock":
                        Result.text = " ";
                        Result.text = "Tie!";
                        break;

                    case "Paper":
                        Result.text = " ";
                        Result.text = "YOU LOSE!";
                        break;

                    case "Scissors":
                        Result.text = " ";
                        Result.text = "YOU WIN!";
                        break;
                }
                AIChoice.sprite = Rock;
                break;

            case "Paper":
                switch (myChoice)
                {
                    case "Rock":
                        Result.text = " ";
                        Result.text = "YOU LOSE!";
                        break;

                    case "Paper":
                        Result.text = " ";
                        Result.text = "TIE!";
                        break;

                    case "Scissors":
                        Result.text = " ";
                        Result.text = "YOU WIN!";
                        break;
                }
                AIChoice.sprite = Paper;
                break;

            case "Scissors":
                switch (myChoice)
                {
                    case "Rock":
                        Result.text = " ";
                        Result.text = "YOU LOSE!";
                        break;

                    case "Paper":
                        Result.text = " ";
                        Result.text = "YOU WIN!";
                        break;

                    case "Scissors":
                        Result.text = " ";
                        Result.text = "Tie!";
                        break;
                }
                AIChoice.sprite = Scissors;
                break;
        } */
    }
}
