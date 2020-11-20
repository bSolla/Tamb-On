using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    int numCancion;
    public void elegirCancion1()
    {
        numCancion = 1;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Jugar()
    {

        if (numCancion == 1)
        {
            StaticClass.CrossSceneInfo = "Songs/Midi_do3_4";
            SceneManager.LoadScene("SampleScene");
        }
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