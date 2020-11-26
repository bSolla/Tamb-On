using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using TMPro;

public class MusicScroll : MonoBehaviour
{
    public GameObject BotonCancion;
    public Transform Content;
    private Text[] m_Text;
    private Image[] m_Image;
    private void Start()
    {
        //TextAsset[] songs = Resources.LoadAll<Texture>("Songs/SongName");
        DirectoryInfo dir = new DirectoryInfo("Assets/Resources/Songs");
        FileInfo[] songs = dir.GetFiles("*.txt");
        SliderMenu sliderM = GetComponent<SliderMenu>();
        int bpm;
        int difficulty;

        foreach (FileInfo s in songs)
        {
            GameObject go = Instantiate(BotonCancion);
            GameObject back = go.transform.GetChild(1).gameObject;
            GameObject frame = go.transform.GetChild(2).gameObject;

            go.transform.SetParent(Content);
            m_Text = go.GetComponentsInChildren<Text>();
            m_Image = go.GetComponentsInChildren<Image>();
            string sName = s.Name;
            
            if (File.Exists(Application.dataPath + "/Resources/Songs/" + sName))
            {
                string[] currentLine = File.ReadAllLines(Application.dataPath + "/Resources/Songs/" + sName);
                m_Text[0].text = currentLine[0];
                m_Text[0].text = m_Text[0].text.Replace("Name: ", "");
                m_Text[1].text = currentLine[1];
                m_Text[1].text = m_Text[1].text.Replace("Author: ", "");
                bpm = Int32.Parse(currentLine[2].Replace("Bpm: ",""));
                difficulty = Int32.Parse(currentLine[3].Replace("Difficulty: ", ""));
                for (int i = 0; i < difficulty+1; i++)
                {
                    m_Image[i].enabled = true;
                }
                back.GetComponent<Image>().sprite = Resources.Load<Sprite>(currentLine[4].Replace("Image: ", ""));
                frame.GetComponent<Image>().sprite = Resources.Load<Sprite>("marc");
            }
            sName = sName.Replace(".txt", "");
            go.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(sName));
            sliderM.Slides.Add(go);
        }
    }

    public void OnButtonClick(string buttonName)
    {
        //Debug.Log(buttonName);
        StaticClass.CrossSceneInfo = "Songs/" + buttonName;
        SceneManager.LoadScene("SampleScene");
    }
}
