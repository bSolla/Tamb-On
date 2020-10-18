using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RhythmManager : MonoBehaviour
{
    #region ---- VARIABLES ----

    #region --- PRIVATE ---

    #endregion
    #region --- PROTECTED ---

    #endregion
    #region --- PUBLIC ---
    public float bpm = 60; // beats per minute, ie tempo
    public float crotchet; // duration of a beat
    public float songPosition; // to be established using AudioSettings.dspTime, for now its just time elapsed
    #endregion

    #endregion


    #region ---- METHODS ----
    #region --- UNITY METHODS ---
    // Start is called before the first frame update
    void Start()
    {
        crotchet = 60 / bpm;
    }

    // Update is called once per frame
    void Update()
    {
        songPosition = Time.time; // not permanent!! TODO
    }
    #endregion

    #region --- CUSTOM METHODS ---

    #endregion
    #endregion
}
