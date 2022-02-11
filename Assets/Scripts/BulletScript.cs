using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    public float speed = 50f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += transform.TransformDirection(Vector3.forward) * 50 * Time.deltaTime;
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        //transform.position += transform.forward * 50 * Time.deltaTime;
        if (Camera.main.WorldToViewportPoint(this.transform.position).y > 1)
        {
            Destroy(this.gameObject);
        }
    }
}
