using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void PVE()
    {
        SceneManager.LoadScene("PongMain");
    }
    public void PVP()
    {
        SceneManager.LoadScene("PongPVP");
    }
}
