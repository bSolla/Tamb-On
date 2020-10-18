using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class MockupButtonMovement : MonoBehaviour
{
    #region ---- VARIABLES ----
    #region --- PRIVATE ---
    private Transform buttonTransform = default;

    private const float LEFT_TRANSLATION = -0.1f;

    #endregion
    #region --- PUBLIC ---
    public bool clickable = false;
    #endregion
    #endregion

    #region ---- METHODS ----
    #region --- UNITY METHODS ---
    // Start is called before the first frame update
    void Start()
    {
        buttonTransform = gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        MoveLeft();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Goal")
        {
            clickable = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Goal")
        {
            clickable = false;

            Invoke("DestroyButton", 1f);
        }
    }
    #endregion

    #region --- CUSTOM METHODS ---
    private void MoveLeft()
    {
        buttonTransform.Translate(new Vector3(LEFT_TRANSLATION, 0f, 0f));
    }

    private void DestroyButton()
    {
        Destroy(gameObject);
    }
    #endregion

    #endregion
}
