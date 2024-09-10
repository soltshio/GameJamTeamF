using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    [SerializeField] float ScrollSpeed = 10;
    bool OnScroll;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Left")
        {
            OnScroll = true;
        }
        else
        {
            OnScroll = false;
        }
    }
    void Update()
    {
        if (OnScroll)
        {
            Vector2 scroll = new Vector2(0, ScrollSpeed);

            transform.Translate(scroll * Time.deltaTime);
        }
    }
}
