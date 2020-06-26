using UnityEngine;
using System.Collections;

public class keyhole : MonoBehaviour
{
    public GameObject key1;
    public GameObject key2;
    public GameObject closeDoor1;
    public GameObject closeDoor2;
    public GameObject door1;
    public GameObject door2;
    public GameObject flag1;
    public GameObject flag2;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if ((tag == "keyhole-1") && (flag1.activeSelf == false)) 
            {
                key1.SetActive(true);
                gameObject.SetActive(false);
                closeDoor1.SetActive(false);
                door1.SetActive(true);
            }

            if ((tag == "keyhole-2") && (flag2.activeSelf == false)) 
            {
                key2.SetActive(true);
                gameObject.SetActive(false);
                closeDoor2.SetActive(false);
                door2.SetActive(true);
            }
        }
    }
}
