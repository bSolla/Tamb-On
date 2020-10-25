using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class MockupButtonMovement : MonoBehaviour
{
    #region ---- VARIABLES ----
    #region --- PRIVATE ---
    private RhythmManager rhythmManager;

    private Transform buttonTransform = default;

    private const float LEFT_TRANSLATION = -0.1f;
    private Vector3 speedDirection = new Vector3(-1f, 0f, 0f);
    private float speed;

    Vector3 originPoint, destinationPoint;
    #endregion

    #region --- PUBLIC ---
    public bool clickable = false;
    #endregion
    #endregion

    #region ---- METHODS ----
    #region --- UNITY METHODS ---
    // Caching of variables and initialization
    void Start()
    {
        rhythmManager = GameManager.instance.rhythmManager;
        buttonTransform = gameObject.transform;
        originPoint = GameObject.FindGameObjectWithTag("Spawner").transform.position;
        destinationPoint = GameObject.FindGameObjectWithTag("Goal").transform.position;

        float timeToReachGoal = rhythmManager.crotchet * 2; // TODO: establish how many beats ahead we want the buttons to spawn

        speed = (Vector2.Distance(destinationPoint, originPoint) / timeToReachGoal);
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
        float step = speed * Time.deltaTime;
        transform.position = new Vector3(
            transform.position.x + speedDirection.x * step,
            transform.position.y + speedDirection.y * step, 
            transform.position.z);
        //buttonTransform.Translate(new Vector3(LEFT_TRANSLATION, 0f, 0f));
    }

    private void DestroyButton()
    {
        Destroy(gameObject);
    }
    #endregion

    #endregion
}
