using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menuniveles : MonoBehaviour
{
    [SerializeField] private GameObject botonpausa;
    [SerializeField] private GameObject menupausa;


    public void pausa()
    {
        Time.timeScale = 0f;
        botonpausa.SetActive(false);
        menupausa.SetActive(true);


    }
    public void reanudar()
    {
        Time.timeScale = 1f;
        botonpausa.SetActive(true);
        menupausa.SetActive(false);
    }
}

