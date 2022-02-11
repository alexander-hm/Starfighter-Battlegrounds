using System.Collections;
using System.Collections.Generic;
//using System.Runtime.Hosting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void Restart ()
    {
        SceneManager.LoadScene("Game");
    }

    public void Menu ()
    {
        SceneManager.LoadScene("Menu");
    }
}
