using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillanoThrowBall : MonoBehaviour
{


    public float speed = 300;
    public float lifeTime = 5;
    public GameObject Player;
    public Rigidbody2D rb;

    void Start()
    {
        speed = 400;
        Player = GameObject.FindGameObjectWithTag("Player");
        Destroy(gameObject, lifeTime);
        rb = GetComponent<Rigidbody2D>();
        //transform.LookAt(Player.transform);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Player.transform.position * speed * Time.deltaTime);
        //rb.AddRelativeForce(new Vector2(-10,0));
        Vector2 direction = Player.transform.position - gameObject.transform.position;
        rb.AddForce(direction.normalized * speed * Time.deltaTime);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            FindObjectOfType<GameManager>().HurtPlayer();
        }
        Destroy(gameObject);
    }
}






