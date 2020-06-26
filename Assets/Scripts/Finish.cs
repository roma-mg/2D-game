using UnityEngine;
using System.Collections;

public class Finish : MonoBehaviour
{
    public GameObject finish_panel;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            finish_panel.SetActive(true);
            Time.timeScale = 0f;
        }

    }

}
