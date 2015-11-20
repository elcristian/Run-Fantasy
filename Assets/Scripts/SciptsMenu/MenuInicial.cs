using UnityEngine;
using System.Collections;

public class MenuInicial : MonoBehaviour {
    public void Play()
    {
        Application.LoadLevel("Scenes1");
    }
    public void Salir()
    {
        Application.Quit();
    }
}
