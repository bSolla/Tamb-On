using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    #region ---- VARIABLES ----

    #region --- PRIVATE ---
    ScoreManager scoreManager;

    const KeyCode INNER_LEFT_TAIKO = KeyCode.F;
    const KeyCode OUTER_LEFT_TAIKO = KeyCode.Q;
    const KeyCode INNER_RIGHT_TAIKO = KeyCode.J;
    const KeyCode OUTER_RIGHT_TAIKO = KeyCode.P;
    #endregion
    #region --- PROTECTED ---

    #endregion

    #region --- PUBLIC ---
    public bool innerTaikoReadyL = false, innerTaikoReadyR = false;
    public bool outerTaikoReadyL = false, outerTaikoReadyR = false;

    public GameObject buttonToDestroyIL, buttonToDestroyIR;
    public GameObject buttonToDestroyOL, buttonToDestroyOR;

    // Booleans for each line for the score and each object to destroy
    public bool innerTaikoReadyLPerfect = false, innerTaikoReadyLHitL = false, innerTaikoReadyLHitR = false, innerTaikoReadyLMissL = false, innerTaikoReadyLMissR = false;
    public bool innerTaikoReadyRPerfect = false, innerTaikoReadyRHitL = false, innerTaikoReadyRHitR = false, innerTaikoReadyRMissL = false, innerTaikoReadyRMissR = false;
    public bool outerTaikoReadyLPerfect = false, outerTaikoReadyLHitL = false, outerTaikoReadyLHitR = false, outerTaikoReadyLMissL = false, outerTaikoReadyLMissR = false;
    public bool outerTaikoReadyRPerfect = false, outerTaikoReadyRHitL = false, outerTaikoReadyRHitR = false, outerTaikoReadyRMissL = false, outerTaikoReadyRMissR = false;

    public GameObject buttonToDestroyILPerfect, buttonToDestroyILHitL, buttonToDestroyILHitR, buttonToDestroyILMissL, buttonToDestroyILMissR;
    public GameObject buttonToDestroyIRPerfect, buttonToDestroyIRHitL, buttonToDestroyIRHitR, buttonToDestroyIRMissL, buttonToDestroyIRMissR;
    public GameObject buttonToDestroyOLPerfect, buttonToDestroyOLHitL, buttonToDestroyOLHitR, buttonToDestroyOLMissL, buttonToDestroyOLMissR;
    public GameObject buttonToDestroyORPerfect, buttonToDestroyORHitL, buttonToDestroyORHitR, buttonToDestroyORMissL, buttonToDestroyORMissR;

    #endregion

    #endregion


    #region ---- METHODS ----
    #region --- UNITY METHODS ---
    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameManager.instance.scoreManager;
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetMouseButton(0))
        //    ReadMouseClick();

        if (Input.GetKeyDown(INNER_LEFT_TAIKO))
        {
            CheckInnerLeftTaiko();
        }
        if (Input.GetKeyDown(INNER_RIGHT_TAIKO))
        {
            CheckInnerRightTaiko();
        }
        if (Input.GetKeyDown(OUTER_LEFT_TAIKO))
        {
            CheckOuterLeftTaiko();
        }
        if (Input.GetKeyDown(OUTER_RIGHT_TAIKO))
        {
            CheckOuterRightTaiko();
        }
    }
    #endregion

    #region --- CUSTOM METHODS ---
    void ReadMouseClick()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast (ray, out hit))
        {
            MockupButtonMovement button = hit.collider.gameObject.GetComponent<MockupButtonMovement>();
            if (button != null && button.clickable) // see if its a button and if its clickable
            {
                Destroy(button.gameObject);
                scoreManager.IncreaseScore(false);
            }
        }
    }

    public void CheckInnerLeftTaiko()
    {
        if (innerTaikoReadyLPerfect)
        {
            Destroy(buttonToDestroyILPerfect);
            scoreManager.IncreaseScore(true);
            innerTaikoReadyLPerfect = false;
        }
        else if (innerTaikoReadyLHitL)
        {
            Destroy(buttonToDestroyILHitL);
            scoreManager.IncreaseScore(false);
            innerTaikoReadyLHitL = false;
        }
        else if (innerTaikoReadyLHitR)
        {
            Destroy(buttonToDestroyILHitR);
            scoreManager.IncreaseScore(false);
            innerTaikoReadyLHitR = false;
        }
        else if (innerTaikoReadyLMissL)
        {
            Destroy(buttonToDestroyILMissL);
            innerTaikoReadyLMissL = false;
        }
        else if (innerTaikoReadyLMissR)
        {
            Destroy(buttonToDestroyILMissR);
            innerTaikoReadyLMissR = false;
        }
    }

    public void CheckInnerRightTaiko()
    {
        if (innerTaikoReadyRPerfect)
        {
            Destroy(buttonToDestroyIRPerfect);
            scoreManager.IncreaseScore(true);
            innerTaikoReadyRPerfect = false;
        }
        else if (innerTaikoReadyRHitL)
        {
            Destroy(buttonToDestroyIRHitL);
            scoreManager.IncreaseScore(false);
            innerTaikoReadyRHitL = false;
        }
        else if (innerTaikoReadyRHitR)
        {
            Destroy(buttonToDestroyIRHitR);
            scoreManager.IncreaseScore(false);
            innerTaikoReadyRHitR = false;
        }
        else if (innerTaikoReadyRMissL)
        {
            Destroy(buttonToDestroyIRMissL);
            innerTaikoReadyRMissL = false;
        }
        else if (innerTaikoReadyRMissR)
        {
            Destroy(buttonToDestroyIRMissR);
            innerTaikoReadyRMissR = false;
        }
    }

    public void CheckOuterLeftTaiko()
    {
        if (outerTaikoReadyLPerfect)
        {
            Destroy(buttonToDestroyOLPerfect);
            scoreManager.IncreaseScore(true);
            outerTaikoReadyLPerfect = false;
        }
        else if (outerTaikoReadyLHitL)
        {
            Destroy(buttonToDestroyOLHitL);
            scoreManager.IncreaseScore(false);
            outerTaikoReadyLHitL = false;
        }
        else if (outerTaikoReadyLHitR)
        {
            Destroy(buttonToDestroyOLHitR);
            scoreManager.IncreaseScore(false);
            outerTaikoReadyLHitR = false;
        }
        else if (outerTaikoReadyLMissL)
        {
            Destroy(buttonToDestroyOLMissL);
            outerTaikoReadyLMissL = false;
        }
        else if (outerTaikoReadyLMissR)
        {
            Destroy(buttonToDestroyOLMissR);
            outerTaikoReadyLMissR = false;
        }
    }

    public void CheckOuterRightTaiko()
    {
        if (outerTaikoReadyRPerfect)
        {
            Destroy(buttonToDestroyORPerfect);
            scoreManager.IncreaseScore(true);
            outerTaikoReadyRPerfect = false;
        }
        else if (outerTaikoReadyRHitL)
        {
            Destroy(buttonToDestroyORHitL);
            scoreManager.IncreaseScore(false);
            outerTaikoReadyRHitL = false;
        }
        else if (outerTaikoReadyRHitR)
        {
            Destroy(buttonToDestroyORHitR);
            scoreManager.IncreaseScore(false);
            outerTaikoReadyRHitR = false;
        }
        else if (outerTaikoReadyRMissL)
        {
            Destroy(buttonToDestroyORMissL);
            outerTaikoReadyRMissL = false;
        }
        else if (outerTaikoReadyRMissR)
        {
            Destroy(buttonToDestroyORMissR);
            outerTaikoReadyRMissR = false;
        }
    }
    #endregion
    #endregion
}
