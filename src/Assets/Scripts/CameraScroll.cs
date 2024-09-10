using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScroll : MonoBehaviour
{
    [SerializeField] float scrollSpeed;//スクロールの速さ
    bool scrollNow=false;//現在スクロールしているか、画面内に足がある間はスクロールする
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool Scroll()//スクロールしてる間はtrue、してない間はfalseを返す
    {
        if (scrollNow)
        {
            Vector2 move= Vector2.up;
            transform.Translate(move*scrollSpeed*Time.deltaTime);
            return true;//スクロールしている
        }

        return false;//スクロールしていない
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("Foot"))
        {
            scrollNow = true;
        }
        else 
        {
            scrollNow=false;
        }
    }
}
