using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class VictoryScene : MonoBehaviour
{

    void Start()
    {
        Invoke("LoadMainMenu",3);//In 3 seconds will invoke LoadMainMenu
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");//Go to MainMenu

    }

}
