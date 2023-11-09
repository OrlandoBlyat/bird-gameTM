using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieArea : MonoBehaviour
{
    public GameObject scoreCounter;

    void OnCollisionEnter2D(Collision2D col)
    {
        scoreCounter.GetComponent<ScoreCounter>().PokeScore(0);
    }
}
