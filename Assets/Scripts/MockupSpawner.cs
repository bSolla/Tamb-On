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
    float bpm, crotchet, lastBeat;
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
        rhythmManager = GameManager.instance.rhythmManager;
        bpm = rhythmManager.bpm;
        crotchet = 60 / bpm;

        //InvokeRepeating("SpawnButtons", 0.5f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        if (rhythmManager.songPosition > lastBeat + crotchet)
        {
            SpawnButtons();

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
