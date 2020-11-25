using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    int numCancion;
 

 

    void Start()
    {
    
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