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
        if (other.tag == "Perfect")
        {
            GameManager.instance.inputManager.outerTaikoReadyLPerfect = true;
            GameManager.instance.inputManager.buttonToDestroyOLPerfect = gameObject;
        }
        else if (other.tag == "HitLeft")
        {
            GameManager.instance.inputManager.outerTaikoReadyLHitL = true;
            GameManager.instance.inputManager.buttonToDestroyOLHitL = gameObject;
        }
        else if (other.tag == "HitRight")
        {
            GameManager.instance.inputManager.outerTaikoReadyLHitR = true;
            GameManager.instance.inputManager.buttonToDestroyOLHitR = gameObject;
        }
        else if (other.tag == "MissLeft")
        {
            GameManager.instance.inputManager.outerTaikoReadyLMissL = true;
            GameManager.instance.inputManager.buttonToDestroyOLMissL = gameObject;
        }
        else if (other.tag == "MissRight")
        {
            GameManager.instance.inputManager.outerTaikoReadyLMissR = true;
            GameManager.instance.inputManager.buttonToDestroyOLMissR = gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Perfect")
        {
            GameManager.instance.inputManager.outerTaikoReadyLPerfect = false;
            GameManager.instance.inputManager.buttonToDestroyOLPerfect = null;


            //GameManager.instance.scoreManager.ScorePenalty();

            Invoke("DestroyButton", 1f);
        }
        else if (other.tag == "HitLeft")
        {
            GameManager.instance.inputManager.outerTaikoReadyLHitL = false;
            GameManager.instance.inputManager.buttonToDestroyOLHitL = null;



            Invoke("DestroyButton", 1f);
        }
        else if (other.tag == "HitRight")
        {
            GameManager.instance.inputManager.outerTaikoReadyLHitR = false;
            GameManager.instance.inputManager.buttonToDestroyOLHitR = null;



            Invoke("DestroyButton", 1f);
        }
        else if (other.tag == "MissLeft")
        {
            GameManager.instance.inputManager.outerTaikoReadyLMissL = false;
            GameManager.instance.inputManager.buttonToDestroyOLMissL = null;


            //GameManager.instance.scoreManager.ScorePenalty();

            Invoke("DestroyButton", 1f);
        }
        else if (other.tag == "MissRight")
        {
            GameManager.instance.inputManager.outerTaikoReadyLMissR = false;
            GameManager.instance.inputManager.buttonToDestroyOLMissR = null;


            Invoke("DestroyButton", 1f);
        }
    }
    #endregion

    #region --- CUSTOM METHODS ---

    #endregion

    #endregion
}
