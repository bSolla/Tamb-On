using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MusicScroll : MonoBehaviour
{
    public GameObject BotonCancion;
    public Transform Content;

    private void Start()
    {
        //TextAsset[] songs = Resources.LoadAll<Texture>("Songs/SongName");
        DirectoryInfo dir = new DirectoryInfo("Assets/Resources/Songs");
        FileInfo[] songs = dir.GetFiles("*.txt");

        foreach (FileInfo s in songs)
        {
            GameObject go = Instantiate(BotonCancion) as GameObject;
            go.transform.SetParent(Content);
            string sName = s.Name;
            sName = sName.Replace(".txt","");
            go.GetComponentInChildren<Text>().text = sName;
            go.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(sName));
        }
    }

    public void OnButtonClick(string buttonName)
    {
        //Debug.Log(buttonName);
        StaticClass.CrossSceneInfo = "Songs/" + buttonName;
        SceneManager.LoadScene("SampleScene");
    }
}
