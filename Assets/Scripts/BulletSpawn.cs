using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.CrossPlatformInput;

public class BulletSpawn : MonoBehaviour
{
    //spawning
    public GameObject spawnPosObject;
    public GameObject spawnRotObject;
    public GameObject bullet;
    
    //audio
    public AudioSource fireAudio;

    //timing
    private float elapsed = 0f;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
        if (CrossPlatformInputManager.GetButton("Fire"))
        {
            elapsed += Time.deltaTime;
            if (elapsed >= 0.1f)
            {
                elapsed = elapsed % 1f;
                fire();
            }
        }

        //audio player
        if (CrossPlatformInputManager.GetButtonDown("Fire"))
        {
            fireAudio.volume = 0.75f;
            fireAudio.Play();
        }
        if (CrossPlatformInputManager.GetButtonUp("Fire"))
        {
            fireAudio.Stop();
        }
    }

    void fire()
    {
        Instantiate(bullet, spawnPosObject.transform.position, spawnRotObject.transform.rotation);
        //fireAudio.Stop();
    }
}