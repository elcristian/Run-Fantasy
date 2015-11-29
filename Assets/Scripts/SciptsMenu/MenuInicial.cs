using UnityEngine;
using System.Collections;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuInicial : MonoBehaviour {
    public void Play()
    {
        Application.LoadLevel("Scenes1");
    }
    public void Credits()
    {
        Application.LoadLevel("Credits");
    }
    public void Salir()
    {
        #if UNITY_EDITOR
        EditorApplication.isPlaying = false;
        #else
        Application.Quit();
        #endif
    }
}
