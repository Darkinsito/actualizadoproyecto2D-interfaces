using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class logicvolume : MonoBehaviour
{
    public Slider slider;
    public float sliderValue;
    public Image imagenMute;

    // functions of volume
    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("Volumenaudio", 0.4f);
        AudioListener.volume = slider.value;
        RevisarSiEstoyMute();
    }
    
    public void ChangeSlider(float valor)
    {
        slider.value = valor;
        PlayerPrefs.SetFloat("voulmenAudio", sliderValue);
        AudioListener.volume = slider.value;
        RevisarSiEstoyMute();
    }

    public void RevisarSiEstoyMute()
    {
        if (sliderValue == 0)
        {
            imagenMute.enabled = true;
        }
        else
        {
            imagenMute.enabled = false;
        }
    }
 }