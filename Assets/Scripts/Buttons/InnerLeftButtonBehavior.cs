using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InnerLeftButtonBehavior : BaseButtonBehavior
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
            GameManager.instance.inputManager.innerTaikoReadyL = true;
            GameManager.instance.inputManager.buttonToDestroyIL = gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Goal")
        {
            GameManager.instance.inputManager.innerTaikoReadyL = false;
            GameManager.instance.inputManager.buttonToDestroyIL = null;


            GameManager.instance.scoreManager.ScorePenalty();

            Invoke("DestroyButton", 1f);
        }
    }
    #endregion

    #region --- CUSTOM METHODS ---
    
    #endregion

    #endregion
}
