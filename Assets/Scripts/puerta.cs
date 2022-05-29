using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class puerta : MonoBehaviour {

    public Transform posJugador;
    public Transform posCamera;
    public GameObject MainCamera;





    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Debug.Log("cambiaste de habiatcion");
            collision.transform.position = posJugador.position;
            MainCamera.transform.position = posCamera.position;

        }
            

        
    }
}
