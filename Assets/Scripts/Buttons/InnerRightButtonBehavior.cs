using System.Collections;
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
        if (other.tag == "Perfect")
        {
            GameManager.instance.inputManager.innerTaikoReadyRPerfect = true;
            GameManager.instance.inputManager.buttonToDestroyIRPerfect = gameObject;
        }
        else if (other.tag == "HitLeft")
        {
            GameManager.instance.inputManager.innerTaikoReadyRHitL = true;
            GameManager.instance.inputManager.buttonToDestroyIRHitL = gameObject;
        }
        else if (other.tag == "HitRight")
        {
            GameManager.instance.inputManager.innerTaikoReadyRHitR = true;
            GameManager.instance.inputManager.buttonToDestroyIRHitR = gameObject;
        }
        else if (other.tag == "MissLeft")
        {
            GameManager.instance.inputManager.innerTaikoReadyRMissL = true;
            GameManager.instance.inputManager.buttonToDestroyIRMissL = gameObject;
        }
        else if (other.tag == "MissRight")
        {
            GameManager.instance.inputManager.innerTaikoReadyRMissR = true;
            GameManager.instance.inputManager.buttonToDestroyIRMissR = gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Perfect")
        {
            GameManager.instance.inputManager.innerTaikoReadyRPerfect = false;
            GameManager.instance.inputManager.buttonToDestroyIRPerfect = null;


            //GameManager.instance.scoreManager.ScorePenalty();

            Invoke("DestroyButton", 1f);
        }
        else if (other.tag == "HitLeft")
        {
            GameManager.instance.inputManager.innerTaikoReadyRHitL = false;
            GameManager.instance.inputManager.buttonToDestroyIRHitL = null;



            Invoke("DestroyButton", 1f);
        }
        else if (other.tag == "HitRight")
        {
            GameManager.instance.inputManager.innerTaikoReadyRHitR = false;
            GameManager.instance.inputManager.buttonToDestroyIRHitR = null;



            Invoke("DestroyButton", 1f);
        }
        else if (other.tag == "MissLeft")
        {
            GameManager.instance.inputManager.innerTaikoReadyRMissL = false;
            GameManager.instance.inputManager.buttonToDestroyIRMissL = null;


            //GameManager.instance.scoreManager.ScorePenalty();

            Invoke("DestroyButton", 1f);
        }
        else if (other.tag == "MissRight")
        {
            GameManager.instance.inputManager.innerTaikoReadyRMissR = false;
            GameManager.instance.inputManager.buttonToDestroyIRMissR = null;


            Invoke("DestroyButton", 1f);
        }
    }
    #endregion

    #region --- CUSTOM METHODS ---

    #endregion

    #endregion
}
