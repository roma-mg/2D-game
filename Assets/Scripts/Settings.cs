using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Settings : MonoBehaviour
{

    public Slider slider;

    void Update()
    {
        AudioListener.volume = slider.value;
    }
}
