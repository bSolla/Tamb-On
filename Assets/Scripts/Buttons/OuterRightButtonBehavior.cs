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
        if (other.tag == "Perfect")
        {
            GameManager.instance.inputManager.outerTaikoReadyRPerfect = true;
            GameManager.instance.inputManager.buttonToDestroyORPerfect = gameObject;
        }
        else if (other.tag == "HitLeft")
        {
            GameManager.instance.inputManager.outerTaikoReadyRHitL = true;
            GameManager.instance.inputManager.buttonToDestroyORHitL = gameObject;
        }
        else if (other.tag == "HitRight")
        {
            GameManager.instance.inputManager.outerTaikoReadyRHitR = true;
            GameManager.instance.inputManager.buttonToDestroyORHitR = gameObject;
        }
        else if (other.tag == "MissLeft")
        {
            GameManager.instance.inputManager.outerTaikoReadyRMissL = true;
            GameManager.instance.inputManager.buttonToDestroyORMissL = gameObject;
        }
        else if (other.tag == "MissRight")
        {
            GameManager.instance.inputManager.outerTaikoReadyRMissR = true;
            GameManager.instance.inputManager.buttonToDestroyORMissR = gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Perfect")
        {
            GameManager.instance.inputManager.outerTaikoReadyRPerfect = false;
            GameManager.instance.inputManager.buttonToDestroyORPerfect = null;


            //GameManager.instance.scoreManager.ScorePenalty();

            Invoke("DestroyButton", 1f);
        }
        else if (other.tag == "HitLeft")
        {
            GameManager.instance.inputManager.outerTaikoReadyRHitL = false;
            GameManager.instance.inputManager.buttonToDestroyORHitL = null;



            Invoke("DestroyButton", 1f);
        }
        else if (other.tag == "HitRight")
        {
            GameManager.instance.inputManager.outerTaikoReadyRHitR = false;
            GameManager.instance.inputManager.buttonToDestroyORHitR = null;



            Invoke("DestroyButton", 1f);
        }
        else if (other.tag == "MissLeft")
        {
            GameManager.instance.inputManager.outerTaikoReadyRMissL = false;
            GameManager.instance.inputManager.buttonToDestroyORMissL = null;


            //GameManager.instance.scoreManager.ScorePenalty();

            Invoke("DestroyButton", 1f);
        }
        else if (other.tag == "MissRight")
        {
            GameManager.instance.inputManager.outerTaikoReadyRMissR = false;
            GameManager.instance.inputManager.buttonToDestroyORMissR = null;


            Invoke("DestroyButton", 1f);
        }
    }
    #endregion

    #region --- CUSTOM METHODS ---

    #endregion

    #endregion
}
