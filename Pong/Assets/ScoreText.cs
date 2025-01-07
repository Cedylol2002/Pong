using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{

    private int scoreOne = 0;
    private int scoreTwo = 0;
    [SerializeField] private TMP_Text Score;
    [SerializeField] private GameObject WonTextGO;
    [SerializeField] private TMP_Text WonText;

    public void increaseScoreOne()
    {
        scoreOne = scoreOne + 1;
        setScoreText();
    }

    public void increaseScoreTwo()
    { 
        scoreTwo = scoreTwo + 1;
        setScoreText();
    }

    private void setScoreText()
    {
        Score.text = scoreOne + ":" + scoreTwo;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            //Restart Game
            scoreOne = 0;
            scoreTwo = 0;
            setScoreText();
            WonTextGO.SetActive(false);
            Time.timeScale = 1f;
        }

        if(scoreOne == 5)
        {
            WonTextGO.SetActive(true);
            Time.timeScale = 0f;
            WonText.text = "Player 1 Won!";
        }

        if (scoreTwo == 5)
        {
            WonTextGO.SetActive(true);
            Time.timeScale = 0f;
            WonText.text = "Player 2 Won!";
        }
    }
}
