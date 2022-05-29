    using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject player;
    public GameObject enemigoF;
    public GameObject enemigoA;
    public GameObject Boss;
    public int PlayerLife;
    public int AguaLife;
    public int BossLife;
    public int FuegoLife;
    public int daño;
    public GameObject puertaV;
    public GameObject puertaC;
    public GameObject puertaB;






    public GameObject[] playerSticks;
    public GameObject[] AguaSticks;
    public GameObject[] FuegoSticks;
    public GameObject[] BossSticks;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerLife <= 0)
        {
            player.SetActive(false);
            // plWins.SetActive(true);
            
        }

        if (AguaLife <= 0)
        {
            enemigoA.SetActive(false);
            
            // p2Wins.SetActive(true);
        }
        if (FuegoLife <= 0)
        {
            enemigoF.SetActive(false);
            // p2Wins.SetActive(true);
        }
        if (BossLife <= 0)
        {
           Boss.SetActive(false);
            // p2Wins.SetActive(true);
        }


     

         







    }

    public void HurtPlayer()
    {
        PlayerLife -= 1;

        for (int i = 0; i < playerSticks.Length; i++)
        {
            if (PlayerLife > i)
            {
                playerSticks[1].SetActive(true);
            }
            else
            {
                playerSticks[i].SetActive(false);
            }
        }
    }
    public void HurtAgua()
    {
        AguaLife -= 1;

        for (int i = 0; i < AguaSticks.Length; i++)
        {
            if (AguaLife > i)
            {
                AguaSticks[1].SetActive(true);
            }
            else
            {
                AguaSticks[i].SetActive(false);
            }
        }
    }
    public void HurtFuego()
    {
        FuegoLife -= 1;

        for (int i = 0; i < FuegoSticks.Length; i++)
        {
            if (FuegoLife > i)
            {
               FuegoSticks[1].SetActive(true);
            }
            else
            {
                FuegoSticks[i].SetActive(false);
            }
        }
    }
    public void HurtBoss()
    {

        BossLife -= 1;
        
        

        for (int i = 0; i < BossSticks.Length; i++)
        {
            if (BossLife > i)
            {
               BossSticks[1].SetActive(true);
            }
            else
            {
               BossSticks[i].SetActive(false);
            }
        }
    }

}
        