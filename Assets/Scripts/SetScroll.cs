using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SetScroll : MonoBehaviour
{
    public Transform contentWindow;
    public GameObject BotonCancionObject;
    public int cojones = 0;
    // Start is called before the first frame update
    void Start()
    {
        string prueba = "ay";
        string prueba2 = "aycoño";
            Instantiate(BotonCancionObject, contentWindow);
            BotonCancionObject.GetComponent<Button>().GetComponentInChildren<Text>().text = prueba;
            Instantiate(BotonCancionObject, contentWindow);
            BotonCancionObject.GetComponent<Button>().GetComponentInChildren<Text>().text = prueba2;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
