using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour {
    public LayerMask ignoreEnemies;

    public SpriteRenderer spriteRenderer;

    public float speed;

    private float waitTime;

    public float startwaitTime;

    public Transform[] moveSpots;

    private int i = 0;

    private Vector2 actualPos;

    public GameObject Player;

    public float distanceRaycast;
    public float cooldownAttack;
    private float actualcooldownAttack;
    public GameObject proyectilTierra;

    public GameObject spawnPoint;


	// Use this for initialization
	void Start () {

        waitTime = startwaitTime;
        actualcooldownAttack = 0;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector2.MoveTowards(transform.position, moveSpots[i].transform.position, speed * Time.deltaTime);

        if(Vector2.Distance(transform.position, moveSpots[i].transform.position) <0.1f)
        {
            if(waitTime<=0)
            {
                if (moveSpots[i]!=moveSpots[moveSpots.Length-1])
                {
                    i++;
                }
                else
                {
                    i = 0;
                }

                waitTime = startwaitTime;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }

        actualcooldownAttack -= Time.deltaTime; 

	}

    private void FixedUpdate()
    {
        //RaycastHit2D hit2D = Physics2D.Raycast(transform.position, Player.transform.position - transform.position, distanceRaycast, ignoreEnemies);

        /*if(hit2D.collider!=null)
        {
           
            if(hit2D.collider.CompareTag("Player"))
            {*/
                
                if(actualcooldownAttack<0)
                {
           
                    Invoke("LaunchBullet", 0.5f);
                    actualcooldownAttack = cooldownAttack;
                }
           //
       // }
    }


    void LaunchBullet()
    {
        
        GameObject newBullet;
        newBullet = Instantiate(proyectilTierra, spawnPoint.transform.position, transform.rotation);
    }

    
}
