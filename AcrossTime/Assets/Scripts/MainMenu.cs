using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    void Update()
    {
        
    }

    public void PVE()
    {
        SceneManager.LoadScene("PlayerVSIA");
    }
    public void PVP()
    {
        SceneManager.LoadScene("PlayerVSPlayer");
    }
}