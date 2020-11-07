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
    public bool taikoReadyL = false;
    public bool taikoReadyR = false;
    public GameObject buttonToDestroyL, buttonToDestroyR;

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
            CheckLeftTaiko();
        }
        if (Input.GetKeyDown(INNER_RIGHT_TAIKO))
        {
            CheckRightTaiko();
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

    public void CheckLeftTaiko()
    {
        if (!taikoReadyL)
        {
            scoreManager.ScorePenalty();
        }
        else
        {
            Destroy(buttonToDestroyL);
            scoreManager.IncreaseScore();
            taikoReadyL = false;
        }
    }

    public void CheckRightTaiko()
    {
        if (!taikoReadyR)
        {
            scoreManager.ScorePenalty(); 
        }
        else
        {
            Destroy(buttonToDestroyR);
            scoreManager.IncreaseScore();
            taikoReadyR = false;
        }
    }
    #endregion
    #endregion
}
