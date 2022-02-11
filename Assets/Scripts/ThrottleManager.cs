using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.CrossPlatformInput
{
    public class ThrottleManager : MonoBehaviour
    {
        GameObject player;
        Movement playerScript;

        void Start()
        {
            player = UnityEngine.GameObject.Find("Player");
            playerScript = player.GetComponent<Movement>();
        }


        void Update()
        {

        }

        void HandleInput(float value)
        {
            //***Set public speed value in the ship script to a different level***
            if (playerScript != null)
            {
                playerScript.throttleUpdate(value);
            }
        }
    }
}
