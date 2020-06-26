using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace RoboGame
{

    public class GameController : MonoBehaviour
    {
        public Bank ScoreBank = new Bank(0);

        private void Start()
        {
            ScoreBank.AddMoney(0);
        }


        private void Awake()
        {
            ExitDoor.OnFinishLevel += ChangeScene;
        }

        public void ChangeScene()
        {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

            if (currentSceneIndex == 1)
            {
                SceneManager.LoadScene(2);
            }
        }

        private void OnDisable()
        {
            ExitDoor.OnFinishLevel -= ChangeScene;
        }

        

    }
}
