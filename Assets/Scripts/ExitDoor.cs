using UnityEngine;
using System.Collections;
using System;

namespace RoboGame
{

    public class ExitDoor : MonoBehaviour
    {
        public static Action OnFinishLevel = () => { };
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                OnFinishLevel();
            }
        }
    }
}