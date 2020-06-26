using UnityEngine;
using System.Collections;
using RoboGame;

public class Money : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GetComponentInParent<AudioSource>().Play();
            if (tag == "gold")
            {
                FindObjectOfType<GameController>().ScoreBank.AddMoney(10);
                gameObject.SetActive(false);
            }
            if (tag == "silver")
            {
                FindObjectOfType<GameController>().ScoreBank.AddMoney(5);
                gameObject.SetActive(false);
            }
            if (tag == "bronze")
            {
                FindObjectOfType<GameController>().ScoreBank.AddMoney(1);
                gameObject.SetActive(false);
            }

            if (tag == "goldS")
            {
                FindObjectOfType<GameController>().ScoreBank.AddMoney(20);
                gameObject.SetActive(false);
            }

        }
    }
}
