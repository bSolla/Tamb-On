using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource audio;
 
    public void SetVolume(float volume)
    {
        audio.volume = volume;
    }
 

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Salir()
    {
        Application.Quit();
        Debug.Log("Salir.");
    }
}
public static class StaticClass
{
    public static string CrossSceneInfo { get; set; }
}