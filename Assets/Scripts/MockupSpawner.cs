using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MockupSpawner : MonoBehaviour
{
    #region ---- VARIABLES ----

    #region --- PRIVATE ---
    [SerializeField]
    BaseButtonBehavior buttonPrefabLeft;
    [SerializeField]
    BaseButtonBehavior buttonPrefabRight;

    RhythmManager rhythmManager;
    float bpm, crotchet, lastBeat = 0;

    // change for the real deal when the file reading is done!! TODO
    Queue<int> spawnTimesLeft = new Queue<int>(new[] { 1, 3, 6, 7, 10, 12, 14, 15, 17, 20,
                                                            24, 25, 28, 29, 30, 33, 34, 36, 40});
    Queue<int> spawnTimesRight = new Queue<int>(new[] { 2, 5, 8, 11, 16, 18, 21, 23, 26, 32,
                                                            35, 37, 38});
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
    }

    // Update is called once per frame
    void Update()
    {
        //if (rhythmManager.songPosition > lastBeat + crotchet)
        //{
        //    SpawnButtons();

        //    lastBeat += crotchet;
        //}

        // check if we need to spawn left buttons
        if (spawnTimesLeft.Count != 0 && rhythmManager.songPosition > crotchet * spawnTimesLeft.Peek())
        {
            SpawnLeftButtons();

            spawnTimesLeft.Dequeue();
        }

        // check if we need to spawn right buttons
        if (spawnTimesRight.Count != 0 && rhythmManager.songPosition > crotchet * spawnTimesRight.Peek())
        {
            SpawnRightButtons();

            spawnTimesRight.Dequeue();
        }
    }
    #endregion

    #region --- CUSTOM METHODS ---
    void SpawnLeftButtons()
    {
        Instantiate(buttonPrefabLeft, this.transform, true);
    }

    void SpawnRightButtons()
    {
        Instantiate(buttonPrefabRight, this.transform, true);
    }
    #endregion
    #endregion
}
