using System.Collections;
using System.Collections.Generic;
//using System.Runtime.Hosting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void PlayGame ()
    {
        SceneManager.LoadScene("Main");
    }

    public void EnterMenu1()
    {
        SceneManager.LoadScene("Menu1");
    }

    public void EnterMenu2 ()
    {
        SceneManager.LoadScene("Menu2");
    }

    public void EnterShipyard ()
    {
        SceneManager.LoadScene("Shipyard");
    }

    public void QuitGame ()
    {
        Application.Quit();
    }



}