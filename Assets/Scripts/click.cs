using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class click : MonoBehaviour
{

    public GameObject menu;
    public GameObject settings;

    public void StartGame()
    {
        Application.LoadLevel(1);
        Time.timeScale = 1f;
    }


    public void Settings()
    {
        menu.SetActive(false);
        settings.SetActive(true);
    }

    public void Back()
    {
        menu.SetActive(true);
        settings.SetActive(false);
    }

    public void Exit_game()
    {
        Application.Quit();
    }

}
