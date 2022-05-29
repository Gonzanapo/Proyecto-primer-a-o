using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvasVida : MonoBehaviour
{

    public GameObject vidaAgua;
    public GameObject vidaFuego;
    public GameObject vidaBoss;
    public GameObject player;

   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "puertaVioleta")
        {
            vidaAgua.SetActive(true);
        }
         if (collision.gameObject.tag == "backVioleta")
         {
            vidaAgua.SetActive(false);
         }
        if (collision.gameObject.tag == "puertaCarcel")
        {
            vidaFuego.SetActive(true);
        }

        if (collision.gameObject.tag == "backCarcel")
        {
            vidaFuego.SetActive(false);
        }
        if (collision.gameObject.tag == "puertaBoss")
        {
            vidaBoss.SetActive(true);
        }
        if (collision.gameObject.tag == "backBoss")
        {
            vidaBoss.SetActive(false);
        }
       





    }
}

