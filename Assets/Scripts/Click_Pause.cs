using UnityEngine;
using System.Collections;

public class Click_Pause : MonoBehaviour
{

    public GameObject Pause_panel;

    public void Play()
    {
        Pause_panel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Exit_menu()
    {
        Application.LoadLevel(0);
    }

    public void Exit_game()
    {
        Application.Quit();
    }
}
