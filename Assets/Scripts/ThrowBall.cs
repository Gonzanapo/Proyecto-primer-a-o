using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowBall : MonoBehaviour
{

    public float ballSpeed;

    private Rigidbody2D theRB;


    // Start is called before the first frame update
    void Start()
    {
        theRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        theRB.velocity = new Vector2(ballSpeed * transform.localScale.x, 0);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.tag == "EnemigoA")
        {
            FindObjectOfType<GameManager>().HurtAgua();
        }
        else  if (other.tag == "EnemigoF")
        {
            FindObjectOfType<GameManager>().HurtFuego();
        }
        else if (other.tag == "Boss")
        {
            FindObjectOfType<GameManager>().HurtBoss();
        }

        //Instantiate(snowBallEffect, transform.position, transform.rotation);

        Destroy(gameObject);

    }
}