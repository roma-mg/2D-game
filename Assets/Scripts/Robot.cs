using UnityEngine;
using System.Collections;

namespace RoboGame
{
    public delegate void OnRobot();

    public class Robot : MonoBehaviour
    {

        private Vector3 _startPos;
        public static OnRobot Dead;
        

        private void Awake()
        {
            _startPos = transform.position;
            Enemy.Kill += ResetPosition;
        }

        void ResetPosition()
        {
            transform.position = _startPos;
        }

        private void OnDisable()
        {
            Enemy.Kill -= ResetPosition;
        }
    }
}
