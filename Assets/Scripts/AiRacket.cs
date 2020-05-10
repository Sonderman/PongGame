using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiRacket : Racket
{
     public Transform ball;
    protected override void Movement()
    {
        Debug.Log(ball.position.y);
        float distange = Mathf.Abs(ball.position.y - transform.position.y);
        if(distange > 2)
        {
            if (ball.position.y > transform.position.y)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, moveSpeed) ;
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, -moveSpeed);
        }
        }
        
    }
}
