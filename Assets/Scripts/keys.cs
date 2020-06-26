using UnityEngine;
using System.Collections;

public class keys : MonoBehaviour
{
    public GameObject key1;
    public GameObject key1_2;
    public GameObject key2;
    public GameObject key2_2;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (tag == "key-1")
            {
                GetComponentInParent<AudioSource>().Play();
                gameObject.SetActive(false);
                key1.SetActive(true);
                key1_2.SetActive(false);
            }

            if (tag == "key-2")
            {
                GetComponentInParent<AudioSource>().Play();
                gameObject.SetActive(false);
                key2.SetActive(true);
                key2_2.SetActive(false);
            }
        }
    }
}
