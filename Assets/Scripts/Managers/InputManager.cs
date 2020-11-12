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
                scoreManager.IncreaseScore();
            }
        }
    }

    public void CheckInnerLeftTaiko()
    {
        if (!innerTaikoReadyL)
        {
            scoreManager.ScorePenalty();
        }
        else
        {
            Destroy(buttonToDestroyIL);
            scoreManager.IncreaseScore();
            innerTaikoReadyL = false;
        }
    }

    public void CheckInnerRightTaiko()
    {
        if (!innerTaikoReadyR)
        {
            scoreManager.ScorePenalty(); 
        }
        else
        {
            Destroy(buttonToDestroyIR);
            scoreManager.IncreaseScore();
            innerTaikoReadyR = false;
        }
    }

    public void CheckOuterLeftTaiko()
    {
        if (!outerTaikoReadyL)
        {
            scoreManager.ScorePenalty();
        }
        else
        {
            Destroy(buttonToDestroyOL);
            scoreManager.IncreaseScore();
            outerTaikoReadyL = false;
        }
    }

    public void CheckOuterRightTaiko()
    {
        if (!outerTaikoReadyR)
        {
            scoreManager.ScorePenalty();
        }
        else
        {
            Destroy(buttonToDestroyOR);
            scoreManager.IncreaseScore();
            outerTaikoReadyR = false;
        }
    }
    #endregion
    #endregion
}
