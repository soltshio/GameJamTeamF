using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JudgeTouchCamera : MonoBehaviour
{
    private bool touchCameraNow=false;

    public bool TouchCameraNow
    {
        get { return touchCameraNow; }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("MainCamera"))
        {
            touchCameraNow = true;
            Debug.Log("触れてます");
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("MainCamera"))
        {
            touchCameraNow = false;
            Debug.Log("触れてません");
        }
    }
}
