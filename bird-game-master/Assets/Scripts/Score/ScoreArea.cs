using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreArea : MonoBehaviour
{
    public GameObject scoreCounter;
    
    void OnTriggerEnter2D(Collider2D col)
    {
        scoreCounter.GetComponent<ScoreCounter>().PokeScore(1);
    }
}
