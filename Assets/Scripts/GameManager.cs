using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region ---- VARIABLES ----

    #region --- PRIVATE ---

    #endregion
    #region --- PROTECTED ---

    #endregion
    #region --- PUBLIC ---
    public static GameManager instance = null;

    public InputManager inputManager;
    public ScoreManager scoreManager;
    public RhythmManager rhythmManager;
    #endregion

    #endregion


    #region ---- METHODS ----
    #region --- UNITY METHODS ---
    // Singleton pattern initialization
    void Awake()
    {
        if (instance == null)
        {
            instance = this;

            DontDestroyOnLoad(this.gameObject);

            scoreManager = GetComponentInChildren<ScoreManager>();
            rhythmManager = GetComponentInChildren<RhythmManager>();
            inputManager = GetComponentInChildren<InputManager>();
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    // caching variables
    private void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }
    #endregion

    #region --- CUSTOM METHODS ---

    #endregion
    #endregion
}
