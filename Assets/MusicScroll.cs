using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class MusicScroll : MonoBehaviour
{
    public GameObject BotonCancion;
    public Transform Content;

    private void Start()
    {
        //TextAsset[] songs = Resources.LoadAll<Texture>("Songs/SongName");
        DirectoryInfo dir = new DirectoryInfo("Assets/Resources/Songs/SongName");
        FileInfo[] songs = dir.GetFiles("*.txt");

        foreach (FileInfo s in songs)
        {
            GameObject go = Instantiate(BotonCancion) as GameObject;
            go.transform.SetParent(Content);
            //go.GetComponentInChildren<Text>().Text = s.ToString();
        }
    }
}
