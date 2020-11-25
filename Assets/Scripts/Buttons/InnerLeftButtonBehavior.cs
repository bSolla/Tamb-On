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
        if (other.tag == "Perfect")
        {
            GameManager.instance.inputManager.innerTaikoReadyLPerfect = true;
            GameManager.instance.inputManager.buttonToDestroyILPerfect = gameObject;
        }
        else if (other.tag == "HitLeft")
        {
            GameManager.instance.inputManager.innerTaikoReadyLHitL = true;
            GameManager.instance.inputManager.buttonToDestroyILHitL = gameObject;
        }
        else if (other.tag == "HitRight")
        {
            GameManager.instance.inputManager.innerTaikoReadyLHitR = true;
            GameManager.instance.inputManager.buttonToDestroyILHitR = gameObject;
        }
        else if (other.tag == "MissLeft")
        {
            GameManager.instance.inputManager.innerTaikoReadyLMissL = true;
            GameManager.instance.inputManager.buttonToDestroyILMissL = gameObject;
        }
        else if (other.tag == "MissRight")
        {
            GameManager.instance.inputManager.innerTaikoReadyLMissR = true;
            GameManager.instance.inputManager.buttonToDestroyILMissR = gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Perfect")
        {
            GameManager.instance.inputManager.innerTaikoReadyLPerfect = false;
            GameManager.instance.inputManager.buttonToDestroyILPerfect = null;


            //GameManager.instance.scoreManager.ScorePenalty();

            Invoke("DestroyButton", 1f);
        }
        else if (other.tag == "HitLeft")
        {
            GameManager.instance.inputManager.innerTaikoReadyLHitL = false;
            GameManager.instance.inputManager.buttonToDestroyILHitL = null;



            Invoke("DestroyButton", 1f);
        }
        else if (other.tag == "HitRight")
        {
            GameManager.instance.inputManager.innerTaikoReadyLHitR = false;
            GameManager.instance.inputManager.buttonToDestroyILHitR = null;



            Invoke("DestroyButton", 1f);
        }
        else if (other.tag == "MissLeft")
        {
            GameManager.instance.inputManager.innerTaikoReadyLMissL = false;
            GameManager.instance.inputManager.buttonToDestroyILMissL = null;


            //GameManager.instance.scoreManager.ScorePenalty();

            Invoke("DestroyButton", 1f);
        }
        else if (other.tag == "MissRight")
        {
            GameManager.instance.inputManager.innerTaikoReadyLMissR = false;
            GameManager.instance.inputManager.buttonToDestroyILMissR = null;


            Invoke("DestroyButton", 1f);
        }
    }
    #endregion

    #region --- CUSTOM METHODS ---

    #endregion

    #endregion
}
