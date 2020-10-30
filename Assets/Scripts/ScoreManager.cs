using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    #region ---- VARIABLES ----

    #region --- PRIVATE ---
    [SerializeField]
    private Text scoreText;
    #endregion
    #region --- PROTECTED ---

    #endregion
    #region --- PUBLIC ---
    public int score = 0;
    #endregion

    #endregion


    #region ---- METHODS ----
    #region --- UNITY METHODS ---
    //// Start is called before the first frame update
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}
    #endregion

    #region --- CUSTOM METHODS ---
    public void UpdateScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
    #endregion
    #endregion
}
