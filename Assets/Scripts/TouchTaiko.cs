using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchTaiko : MonoBehaviour
{
    #region ---- VARIABLES ----

    #region --- PRIVATE ---
    #endregion
    #region --- PROTECTED ---
    #endregion
    #region --- PUBLIC ---
    public enum AreaType
    {
        INNER_R,
        INNER_L,
        OUTER_R,
        OUTER_L
    }
    public AreaType areaType;
    #endregion

    #endregion


    #region ---- METHODS ----
    #region --- UNITY METHODS ---
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
            ReadMouseClick();
    }
    #endregion

    #region --- CUSTOM METHODS ---
    void ReadMouseClick()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
        {
            CallInputManager();
        }

    }

    void CallInputManager()
    {
        switch (areaType)
        {
            case AreaType.INNER_R:
                GameManager.instance.inputManager.CheckInnerRightTaiko();
                Debug.Log("inner right");
                break;
            case AreaType.INNER_L:
                GameManager.instance.inputManager.CheckInnerLeftTaiko();
                Debug.Log("inner left");
                break;
            case AreaType.OUTER_R:
                GameManager.instance.inputManager.CheckOuterRightTaiko();
                Debug.Log("outer right");
                break;
            case AreaType.OUTER_L:
                GameManager.instance.inputManager.CheckOuterLeftTaiko();
                Debug.Log("outer left");
                break;
            default:
                break;
        }
    }

    #endregion
    #endregion
};
