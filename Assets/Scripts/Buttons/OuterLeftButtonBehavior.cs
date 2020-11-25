using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuterLeftButtonBehavior : BaseButtonBehavior
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
            GameManager.instance.inputManager.outerTaikoReadyL = true;
            GameManager.instance.inputManager.buttonToDestroyOL = gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Goal")
        {
            GameManager.instance.inputManager.outerTaikoReadyL = false;
            GameManager.instance.inputManager.buttonToDestroyOL = null;


            GameManager.instance.scoreManager.ScorePenalty();

            Invoke("DestroyButton", 1f);
        }
    }
    #endregion

    #region --- CUSTOM METHODS ---

    #endregion

    #endregion
}
