using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class birdscript : MonoBehaviour

{
    public float flap;
    public ScoreCounter scoreCounter;
    public GameObject deathAnimation;

    // Update is called once per frame
    void Update()
    {
        if (scoreCounter.currentScore == -1)
        {
            return;
        }

        if (Input.GetKeyDown(KeyCode.Space) != true)
        {
            return;
        }

        gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.up * flap;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (scoreCounter.currentScore == -1)
        {
            return;
        }
        
        if (col.gameObject.CompareTag("ScoreGood"))
        {
            scoreCounter.PokeScore(1);
            return;
        }
        
        scoreCounter.PokeScore(0);
        deathAnimation.GetComponent<ParticleSystem>().Play();
    }
}
