using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;

    //AI
    public Transform target;
    public GameObject player;
    //float timer = 0;
    public float trackSpeed;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //forward movement
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        //find direction to rotate towards
        Vector3 targetDirection = player.transform.position - transform.position;
        //step size
        float singleStep = trackSpeed * Time.deltaTime;
        //Rotate the forward vector towards the target direction by one step
        Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, singleStep, 0.0f);
        
        transform.rotation = Quaternion.LookRotation(newDirection);

        //Apply calculated step rotation
        //transform.rotation = XLookRotation(player.transform.position - transform.position);
    }

    void OnTriggerEnter(Collider c)
    {
        if (c.tag == "Laser" /*|| c.tag == "Player"*/)
        {
            Destroy(c.gameObject);
            Destroy(gameObject);
        }
    }

    Quaternion XLookRotation(Vector3 right)
    {
        Vector3 up = Vector3.up;
        Quaternion rightToForward = Quaternion.Euler(0f, -90f, 0f);
        Quaternion forwardToTarget = Quaternion.LookRotation(right, up);

        return forwardToTarget * rightToForward;
    }
}
