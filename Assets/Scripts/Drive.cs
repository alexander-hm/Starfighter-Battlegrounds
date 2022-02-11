using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.AccessControl;
using System.Threading;
using UnityEngine;
using System.IO;
using System.Text;
using System.Collections.Specialized;
using System.Security.Cryptography;

public class Drive : MonoBehaviour
{
    public int speed = 20;

    // Update is called once per frame
    void Update()
    {
        //rb.AddForce(10000f * Time.deltaTime, 0, 0);
        /*if (Input.GetKey("w"))
        {
            rb.AddForce(5000 * Time.deltaTime, 0, 0);
        }*/
        transform.Translate(Vector3.right * Time.deltaTime * speed);

    }
    /*
    void OnTriggerEnter(Collider c)
    {
        if (c.tag == "Despawn")
        {
            System.Console.WriteLine("Car hit");
            transform.position = respawn;
            //Destroy(this.gameObject);
            //Instantiate(this, new Vector3(-69.2f, 5.78f, -14.57f), new Quaternion(0, 0, 0, 0));
            //health -= 5;
            //GO TO GAME OVER SCENE
        }
    }
    */
}
