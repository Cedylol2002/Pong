using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField] private Goal _EnemyGoal;
    [SerializeField] private bool isPlayerOne;

    public void Score()
    {
        _EnemyGoal.Scored();
    }

    public void Scored()
    {
        if(isPlayerOne)
        {
            Debug.Log("Player 1 scored!");
        }
        else
        {
            Debug.Log("Player 2 scored!");
        }
    }
}
