using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    // KEVIN NOTE: not very memory safe but oh well 
    public int currentScore = 0;
    public TMP_Text scoreText;
    public GameObject deathScreen;

    public void PokeScore(int action)
    {
        if (action == 1)
        {
            currentScore++; 
        }
        else
        {
            currentScore = -1;
        }
        
        if (currentScore != -1)
        {
            return;
        }
        
        deathScreen.SetActive(true);
    }
}
