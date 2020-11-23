using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MusicScroll : MonoBehaviour
{
    public GameObject BotonCancion;
    public Transform Content;
    private Text m_Text;
    private void Start()
    {
        //TextAsset[] songs = Resources.LoadAll<Texture>("Songs/SongName");
        DirectoryInfo dir = new DirectoryInfo("Assets/Resources/Songs");
        FileInfo[] songs = dir.GetFiles("*.txt");

        foreach (FileInfo s in songs)
        {
            GameObject go = Instantiate(BotonCancion);
            
            go.transform.SetParent(Content);
            string sName = s.Name;
            sName = sName.Replace(".txt","");
            m_Text = go.GetComponentInChildren<Text>();
            m_Text.text = sName;
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
