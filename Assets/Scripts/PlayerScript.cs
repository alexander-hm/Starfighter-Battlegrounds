using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System;

public class PlayerScript : MonoBehaviour
{
    public Animator anim;
    public GameObject playerCam;
    public float mouseSens = 120f;

    //public AudioSource audioClip;
    int fatigue = 0;
    bool gameHasEnded = false;

    //public Text hp;
    //int health = 100;
    //float winTimer = 0;

    // Use this for initialization
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        //winTimer += Time.deltaTime;

        if (Input.GetKey("w") || Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("d"))
        {
            anim.SetTrigger("Walk");
        }
        if (!Input.anyKey)
        {
            //anim.SetTrigger("Idle");
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * (3 + fatigue));
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * (2 + fatigue));
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * (2 + fatigue));
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * (2 + fatigue));
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.up * Time.deltaTime * 3);
        }
        if (Input.GetAxis("Mouse X") > 0f)
        {
            transform.Rotate(0, mouseSens * Time.deltaTime, 0);
        }
        if (Input.GetAxis("Mouse X") < 0f)
        {
            transform.Rotate(0, -mouseSens * Time.deltaTime, 0);
        }
        if (Input.GetAxis("Mouse Y") > 0f)
        {
            playerCam.transform.Rotate(-mouseSens * Time.deltaTime, 0, 0);
        }
        if (Input.GetAxis("Mouse Y") < 0f)
        {
            playerCam.transform.Rotate(mouseSens * Time.deltaTime, 0, 0);
        }
    }
    void OnTriggerEnter(Collider c)
    {
        if (c.tag == "Car" || c.tag == "Bus" || c.tag == "Truck")
        {
            EndGame();
        }

        else if (c.tag == "Player")
        {
            Cursor.visible = true;
            SceneManager.LoadScene("Win");
        }
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {

            //audioClip.Play();
            Cursor.visible = true;
            gameHasEnded = true;
            
            SceneManager.LoadScene("Lose");
        }
    }
}
