using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{

    private int scoreOne = 0;
    private int scoreTwo = 0;
    [SerializeField] private TMP_Text Score;

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
}
