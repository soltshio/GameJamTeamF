using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScroll : MonoBehaviour
{
    [SerializeField] float scrollSpeed;//スクロールの速さ
    bool scrollNow=false;//現在スクロールしているか、足がカメラに触れている時はスクロールする

    public bool ScrollNow
    {
        get { return scrollNow; }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ScrollTrigger()//スクロール時に呼ぶ(これを状態開始時に呼ばないとスクロールされない)
    {
        scrollNow = true;
    }

    public void Scroll()//スクロールしてる間はtrue、してない間はfalseを返す
    {
        if (scrollNow)
        {
            Vector2 move= Vector2.up;
            transform.Translate(move*scrollSpeed*Time.deltaTime);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Foot"))
        {
            scrollNow = false;
            Debug.Log("触れてません");
        }
    }
}
