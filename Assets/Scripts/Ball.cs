using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D rb2;
    public float moveSpeed = 10;
    public Racket LeftRacket, RightRacket;
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
        rb2.velocity = new Vector2(1, 0) * moveSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        TagManager tagManager = collision.gameObject.GetComponent<TagManager>();
        GetComponent<AudioSource>().Play();

        if (tagManager == null) return;

        Tag tag = tagManager.myTag;

        if (tag.Equals(Tag.Right_Wall))
        {
            LeftRacket.MakeScore();
        }
        else if (tag.Equals(Tag.Left_Wall))
        {
            RightRacket.MakeScore();
        }

        if (tag.Equals(Tag.Right_Racket))
        {
            CalculateVelo(collision, -1);
        }
        else if (tag.Equals(Tag.Left_Racket))
        {
            CalculateVelo(collision, 1);
        }
    }

    private void CalculateVelo(Collision2D collision, int x)
    {
        float a = transform.position.y - collision.gameObject.transform.position.y;
        float b = collision.collider.bounds.size.y;
        float y = a / b;
        // Debug.Log(y);
        if (y == 0.0)
        {
            y = (float)0.5;
        }
        rb2.velocity = new Vector2(x, y) * moveSpeed;
    }

}
