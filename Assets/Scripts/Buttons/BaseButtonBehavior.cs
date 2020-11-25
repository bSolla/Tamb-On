using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseButtonBehavior : MonoBehaviour
{
    #region ---- VARIABLES ----

    #region --- PRIVATE ---

    #endregion
    #region --- PROTECTED ---
    protected RhythmManager rhythmManager;

    protected Transform buttonTransform = default;

    protected const float LEFT_TRANSLATION = -0.1f;
    protected Vector3 speedDirection = new Vector3(-1f, 0f, 0f);
    protected float speed;

    protected Vector3 originPoint, destinationPoint;
    #endregion
    #region --- PUBLIC ---
    #endregion

    #endregion


    #region ---- METHODS ----
    #region --- UNITY METHODS ---
    // Start is called before the first frame update
    void Start()
    {
        Initialize();
    }

    // Update is called once per frame
    void Update()
    {

    }
    #endregion

    #region --- CUSTOM METHODS ---
    protected void Initialize()
    {
        rhythmManager = GameManager.instance.rhythmManager;
        buttonTransform = gameObject.transform;
        originPoint = GameObject.FindGameObjectWithTag("Spawner").transform.position;
        destinationPoint = GameObject.FindGameObjectWithTag("MissLeft").transform.position;

        float timeToReachGoal = rhythmManager.crotchet * 2; // TODO: establish how many beats ahead we want the buttons to spawn

        speed = (Vector2.Distance(destinationPoint, originPoint) / timeToReachGoal);
    }

    protected void MoveLeft()
    {
        float step = speed * Time.deltaTime;
        transform.position = new Vector3(
        transform.position.x + speedDirection.x * step,
        transform.position.y + speedDirection.y * step,
        transform.position.z);
    }

    protected void DestroyButton()
    {
        Destroy(gameObject);
    }
    #endregion
    #endregion
}
