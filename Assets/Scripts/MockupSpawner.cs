using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MockupSpawner : MonoBehaviour
{
    #region ---- VARIABLES ----

    #region --- PRIVATE ---
    [SerializeField]
    BaseButtonBehavior buttonPrefabInnerLeft;
    [SerializeField]
    BaseButtonBehavior buttonPrefabInnerRight;
    [SerializeField]
    BaseButtonBehavior buttonPrefabOuterLeft;
    [SerializeField]
    BaseButtonBehavior buttonPrefabOuterRight;

    RhythmManager rhythmManager;
    float bpm, crotchet, lastBeat = 0;

    // change for the real deal when the file reading is done!! TODO
    Queue<int> spawnTimesInnerLeft = new Queue<int>();
    Queue<int> spawnTimesInnerRight = new Queue<int>();
    Queue<int> spawnTimesOuterLeft = new Queue<int>(new[] { 1, 3, 6, 7, 10, 12, 14, 15, 17, 20,
                                                            24, 25, 28, 29, 30, 33, 34, 36, 40});
    Queue<int> spawnTimesOuterRight = new Queue<int>(new[] { 2, 5, 8, 11, 16, 18, 21, 23, 26, 32,
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
        if (spawnTimesInnerLeft.Count != 0 && rhythmManager.songPosition > crotchet * spawnTimesInnerLeft.Peek())
        {
            SpawnInnerLeftButtons();

            spawnTimesInnerLeft.Dequeue();
        }
        if (spawnTimesOuterLeft.Count != 0 && rhythmManager.songPosition > crotchet * spawnTimesOuterLeft.Peek())
        {
            SpawnOuterLeftButtons();

            spawnTimesOuterLeft.Dequeue();
        }

        // check if we need to spawn right buttons
        if (spawnTimesInnerRight.Count != 0 && rhythmManager.songPosition > crotchet * spawnTimesInnerRight.Peek())
        {
            SpawnInnerRightButtons();

            spawnTimesInnerRight.Dequeue();
        }
        if (spawnTimesOuterRight.Count != 0 && rhythmManager.songPosition > crotchet * spawnTimesOuterRight.Peek())
        {
            SpawnOuterRightButtons();

            spawnTimesOuterRight.Dequeue();
        }
    }
    #endregion

    #region --- CUSTOM METHODS ---
    void SpawnInnerLeftButtons()
    {
        Instantiate(buttonPrefabInnerLeft, this.transform, true);
    }

    void SpawnInnerRightButtons()
    {
        Instantiate(buttonPrefabInnerRight, this.transform, true);
    }

    void SpawnOuterLeftButtons()
    {
        Instantiate(buttonPrefabOuterLeft, this.transform, true);
    }

    void SpawnOuterRightButtons()
    {
        Instantiate(buttonPrefabOuterRight, this.transform, true);
    }
    #endregion
    #endregion
}
