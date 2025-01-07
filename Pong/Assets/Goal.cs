using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField] private Goal _EnemyGoal;
    [SerializeField] private ScoreText _ScoreText;
    [SerializeField] private bool isPlayerOne;

    public void Score()
    {
        _EnemyGoal.Scored();
    }

    public void Scored()
    {
        if(isPlayerOne)
        {
            _ScoreText.increaseScoreOne();
        }
        else
        {
            _ScoreText.increaseScoreTwo();
        }
    }
}
