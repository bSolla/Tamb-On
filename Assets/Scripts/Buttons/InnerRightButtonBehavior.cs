﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InnerRightButtonBehavior : BaseButtonBehavior
{
    #region ---- VARIABLES ----
    #region --- PRIVATE ---
    #endregion

    #region --- PUBLIC ---
    #endregion
    #endregion

    #region ---- METHODS ----
    #region --- UNITY METHODS ---
    // Caching of variables and initialization
    void Start()
    {
        Initialize();
    }


    private void FixedUpdate()
    {
        MoveLeft();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Goal")
        {
            GameManager.instance.inputManager.innerTaikoReadyR = true;
            GameManager.instance.inputManager.buttonToDestroyIR = gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Goal")
        {
            GameManager.instance.inputManager.innerTaikoReadyR = false;
            GameManager.instance.inputManager.buttonToDestroyIR = null;


            GameManager.instance.scoreManager.ScorePenalty();

            Invoke("DestroyButton", 1f);
        }
    }
    #endregion

    #region --- CUSTOM METHODS ---

    #endregion

    #endregion
}