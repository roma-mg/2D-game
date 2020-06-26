using UnityEngine;
using System.Collections;

public class Pause_menu : MonoBehaviour
{

    public GameObject Pause_panel;

    private bool pause = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pause)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    private void Resume()
    {
        Pause_panel.SetActive(false);
        Time.timeScale = 1f;
        pause = false;
    }

    private void Pause()
    {
        Pause_panel.SetActive(true);
        Time.timeScale = 0f;
        pause = true;
    }

}
