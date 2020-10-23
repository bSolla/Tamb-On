using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MockupSpawner : MonoBehaviour
{
    #region ---- VARIABLES ----

    #region --- PRIVATE ---
    [SerializeField]
    MockupButtonMovement buttonPrefab;

    RhythmManager rhythmManager;
    FileReader fileReader;
    float bpm, crotchet, lastBeat;
    int cont;
    Queue notes;
    #endregion
    #region --- PROTECTED ---

    #endregion
    #region --- PUBLIC ---
    #endregion

    #endregion


    #region ---- METHODS ----
    #region --- UNITY METHODS ---
    // Start is called before the first frame update
    void Start()
    {
        rhythmManager = GameObject.FindGameObjectWithTag("RhythmManager").GetComponent<RhythmManager>();
        bpm = rhythmManager.bpm;
        crotchet = 60 / bpm;
        cont = 0;
        fileReader = GameObject.FindGameObjectWithTag("FileReader").GetComponent<FileReader>();
        notes = fileReader.notes;

        //InvokeRepeating("SpawnButtons", 0.5f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        if (rhythmManager.songPosition > lastBeat + crotchet)
        {
            cont++;
            if (cont == (int) notes.Peek()) {
                SpawnButtons();
                notes.Dequeue();
            }

            lastBeat += crotchet;
        }
    }
    #endregion

    #region --- CUSTOM METHODS ---
    void SpawnButtons()
    {
        Instantiate(buttonPrefab, this.transform, true);
    }
    #endregion
    #endregion
}
