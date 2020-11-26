using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class FileReader : MonoBehaviour
{
    #region ---- PRIVATE ----


    string songname, author, difficulty;
    int bpm, compas1, compas2;
    string[] notesPerComp;
    public Queue notes = new Queue();
    public int a;

    #endregion
    #region ---- PUBLIC ----

    #endregion
    // Start is called before the first frame update
    void Awake()
    {
       /* string song = Application.dataPath + "/Resources/Songs/song1.txt";
        if (File.Exists(song)) {
            string[] text = File.ReadAllLines(song);
            songname = text[0];
            author = text[1];
            bpm = Int32.Parse(text[2]);
            compas1 = Int32.Parse(text[3]);
            compas2 = Int32.Parse(text[4]);
            difficulty = text[5];
            notesPerComp = text[6].Split(new string[] { " " }, StringSplitOptions.None);
            foreach (string note in notesPerComp) {
                notes.Enqueue(Int32.Parse(note));
            }
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
