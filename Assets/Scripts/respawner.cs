using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class respawner : MonoBehaviour
{
    public Vector3 pos;
    public Vector3 posB;
    public Vector3 posT;
    void OnTriggerEnter(Collider c)
    {
        if (c.tag == "Car")
        {
            //System.Console.WriteLine("Car hit");
            c.gameObject.transform.position = pos;
            //Destroy(this.gameObject);
        }
        if (c.tag == "Bus")
        {
            c.gameObject.transform.position = posB;
        }
        if (c.tag == "Truck")
        {
            c.gameObject.transform.position = posT;
        }
    }
}
