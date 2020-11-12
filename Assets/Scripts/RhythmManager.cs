﻿using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using SmfLite;
using System;

public class RhythmManager : MonoBehaviour
{
    #region ---- VARIABLES ----

    #region --- PRIVATE ---
    bool first;
    #endregion
    #region --- PROTECTED ---

    #endregion
    #region --- PUBLIC ---
    public float bpm; // beats per minute, ie tempo
    public float crotchet; // duration of a beat
    public float songPosition; // to be established using AudioSettings.dspTime, for now its just time elapsed
    #endregion

    #endregion


    #region ---- METHODS ----
    #region --- UNITY METHODS ---
    // initialization of internal values
    MidiFileContainer song;
    MidiTrackSequencer sequencer;
    public TextAsset midiFile;
    // Start is called before the first frame update
    void Start()
    {
        
        song = MidiFileLoader.Load(midiFile.bytes);
        sequencer = new MidiTrackSequencer(song.tracks[0], song.division, bpm);
        SendMidiMessages(sequencer.Start());
        StartCoroutine(playSong());
       
    }
    private IEnumerator playSong()
    {
        yield return new WaitForSeconds(0.75f);
        GetComponent<AudioSource>().Play();
    }

    private void SendMidiMessages(List<MidiEvent> m)
    {
        if (m != null)
        {
            foreach (MidiEvent i in m)
            {
                if ((i.status & 0xf0) == 0x90)
                {
                    if (i.data1 == 0x30)
                    {
                        GameObject.Find("Spawner").SendMessage("SpawnButtons");
                    }
                    else if (i.data1 == 0x3C)
                    {
                        GameObject.Find("Spawner").SendMessage("SpawnButtons");
                    }
                }
            }
        }
    }

    void Awake()
    {
        first = true;
        crotchet = 60 / bpm;
    }

    // Update is called once per frame
    void Update()
    {
        //songPosition = Time.time; // not permanent!! TODO
        if (sequencer != null && sequencer.Playing)
        {
            SendMidiMessages(sequencer.Advance(Time.deltaTime));
        }
    }
    #endregion
    public void Play()
    {
        if (first)
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            first = false;
        }
    }
    #region --- CUSTOM METHODS ---

    #endregion
    #endregion
}
