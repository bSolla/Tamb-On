using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class FileReader : MonoBehaviour
{
    #region ---- PRIVATE ----
    string song = "D:/TFG/taiko/Assets/Resources/Songs/song1.txt";
    string songname, author, difficulty;
    int bpm, compas1, compas2;
    string[] notesPerComp;
    List<List<int>> notes = new List<List<int>>();

    #endregion
    #region ---- PUBLIC ----

    #endregion
    // Start is called before the first frame update
    void Start()
    {
        if (File.Exists(song)) {
            string[] text = File.ReadAllLines(song);
            songname = text[0];
            author = text[1];
            bpm = Int32.Parse(text[2]);
            compas1 = Int32.Parse(text[3]);
            compas2 = Int32.Parse(text[4]);
            difficulty = text[5];
            for (int i = 0; i < Int32.Parse(text[6]); i++) {
                notesPerComp = text[i + 7].Split(new string[] { " " }, StringSplitOptions.None);
                List<int> subnotes = new List<int>();
                foreach (string note in notesPerComp) {
                    subnotes.Add(Int32.Parse(note));
                }
                notes.Add(subnotes);
            }
            print(songname);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
