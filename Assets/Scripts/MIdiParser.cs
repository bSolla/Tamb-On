using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SmfLite;

public class MIdiParser : MonoBehaviour
{
    MidiFileContainer song;
    MidiTrackSequencer secuencer;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().Play();
        secuencer = new MidiTrackSequencer(song.tracks[0], song.division, 131.0f);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
