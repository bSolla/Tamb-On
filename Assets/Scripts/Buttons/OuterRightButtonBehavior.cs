using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuterRightButtonBehavior : BaseButtonBehavior
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
            GameManager.instance.inputManager.outerTaikoReadyR = true;
            GameManager.instance.inputManager.buttonToDestroyOR = gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Goal")
        {
            GameManager.instance.inputManager.outerTaikoReadyR = false;
            GameManager.instance.inputManager.buttonToDestroyOR = null;


            GameManager.instance.scoreManager.ScorePenalty();

            Invoke("DestroyButton", 1f);
        }
    }
    #endregion

    #region --- CUSTOM METHODS ---

    #endregion

    #endregion
}
