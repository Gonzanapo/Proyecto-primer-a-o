using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;

    public KeyCode left;
    public KeyCode right;
    public KeyCode up;
    public KeyCode down;
    public KeyCode throwBall;

    private Rigidbody2D theRB;
    public GameManager HurtBoss;
    public GameObject ThrowBall;
    public GameObject throwEsfera;
    public Transform ThrowPoint;
    public bool tieneEsfera;

    // Start is called before the first frame update
    void Start()
    {
        theRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(left))
        {
            theRB.velocity = new Vector2(-moveSpeed, theRB.velocity.y);
        }
        else if (Input.GetKey(up))
        {
            theRB.velocity = new Vector2(theRB.velocity.x, moveSpeed);
        }
        else if (Input.GetKey(down))
        {
            theRB.velocity = new Vector2 (theRB.velocity.x, -moveSpeed);
        }
        else if (Input.GetKey(right))
        {
            theRB.velocity = new Vector2(moveSpeed, theRB.velocity.y);
        }
        else
        {
            theRB.velocity = new Vector2(0, 0);
        }

        if (theRB.velocity.x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }

        else if (theRB.velocity.x > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (theRB.velocity.y > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }

        if (Input.GetKeyDown(throwBall))
        {
            GameObject ballClone = (GameObject) Instantiate(ThrowBall, ThrowPoint.position, ThrowPoint.rotation);
            ballClone.transform.localScale = transform.localScale;
        }
        
        if(tieneEsfera)
        {
            if(Input.GetKeyDown(KeyCode.Q))
            {

                
                //Quilombo le saco vida
                GameObject Esfera = (GameObject)Instantiate(throwEsfera, ThrowPoint.position, ThrowPoint.rotation);
                Esfera.transform.localScale = transform.localScale;
            }

        }
    }
}

