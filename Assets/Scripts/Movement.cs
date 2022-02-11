using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
    {
        //general    
        public MeshCollider meshCollider;
        public Rigidbody rb;
        public Camera playerCam;

        //motion
        public float speedConst = 100f;
        public float finalSpeed;
        public float sensitivity = 100f;
        public float horSens = 1f;
        public float vertSens = 1f;
        public float zSens = 1f;

    //flame animation
        public GameObject flames;
        float xScale;
        float yScale;
        float zScale;

    // Start is called before the first frame update
        void Start()
        {
            //initialize final speed based on the speed constant
            finalSpeed = speedConst;
            //log original flame scale
            xScale = flames.transform.localScale.x;
            yScale = flames.transform.localScale.y;
            zScale = flames.transform.localScale.z;
        }

        // Update is called once per frame
        void Update()
        {
            //forward velocity
            transform.Translate(-Vector3.right * Time.deltaTime * finalSpeed);

        //***TrackPad turning control
        float hor = CrossPlatformInputManager.GetAxis("Horizontal");
        float vert = CrossPlatformInputManager.GetAxis("Vertical");
        if (hor > 0.01f)
        {
            transform.Rotate(0, 0, hor * sensitivity * Time.deltaTime * horSens);
        }
        if (hor < -0.01f)
        {
            transform.Rotate(0, 0, hor * sensitivity * Time.deltaTime * horSens);
        }
        //
        if (vert > 0.01f)
        {
            transform.Rotate(0, vert * sensitivity * Time.deltaTime * vertSens, 0);
        }
        if (vert < -0.01f)
        {
            transform.Rotate(0, vert * sensitivity * Time.deltaTime * vertSens, 0);
        }
        //
        float hor2 = CrossPlatformInputManager.GetAxis("Horizontal2");
        float vert2 = CrossPlatformInputManager.GetAxis("Vertical2");
        if (hor2 > 0.01f)
        {
            transform.Rotate(hor2 * sensitivity * Time.deltaTime * zSens, 0, 0);
        }
        if (hor2 < -0.01f)
        {
            transform.Rotate(hor2 * sensitivity * Time.deltaTime * zSens, 0, 0);
        }
    }

    void OnTriggerEnter(Collider c)
    {
        if (/*c.tag == "Laser" ||*/ c.tag == "Enemy" || c.tag == "Asteroid")
        {
            SceneManager.LoadScene("Menu2");
            Destroy(c.gameObject);
            //Destroy(gameObject);
        }
    }

    public void throttleUpdate(float value)
    {
        finalSpeed = speedConst * (value + 0.5f);
        flames.transform.localScale = new Vector3((xScale * (value + 0.5f)), yScale, zScale);
    }
}