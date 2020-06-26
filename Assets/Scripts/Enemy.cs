using UnityEngine;
using System.Collections;

namespace RoboGame
{
    public delegate void EnemyDelegate();

    public class Enemy : MonoBehaviour
    {
        private int HealthPoint=30;
        public static EnemyDelegate Kill;
        public GameObject HP_25;
        public GameObject HP_15;
        public GameObject HP_5;
        public GameObject die;
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                Kill();
                HealthPoint -= 5;
                if (HealthPoint == 25)
                {
                    GameObject.Find("Canvas/HP-30").SetActive(false);
                    HP_25.SetActive(true);
                }

                if (HealthPoint == 20)
                {                 
                    HP_25.SetActive(false);
                }

                if (HealthPoint == 15)
                {
                    GameObject.Find("Canvas/HP-20").SetActive(false);
                    HP_15.SetActive(true);
                }

                if (HealthPoint == 10)
                {
                    HP_15.SetActive(false);
                }

                if (HealthPoint == 5)
                {
                    GameObject.Find("Canvas/HP-10").SetActive(false);
                    HP_5.SetActive(true);
                }

                if (HealthPoint == 0)
                {
                    HP_5.SetActive(false);
                    die.SetActive(true);
                    Time.timeScale = 0f;
                }
            }
        }

    }
}

