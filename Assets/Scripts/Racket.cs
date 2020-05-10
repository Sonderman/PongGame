using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Racket : MonoBehaviour
{
    
    public float moveSpeed = 10;
    public Text scoreText;
    public int Score { get; private set; }
    
    void FixedUpdate()
    {
        Movement();
    }

    protected abstract void Movement();
    

    public void MakeScore()
    {
        Score++;
        scoreText.text = Score.ToString();
    }
}
