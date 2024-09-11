using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{
    CurrentFoot currentFoot;
    ToGameOver toGameOver;

    void Start()
    {
        currentFoot = GameObject.FindWithTag("FootManager").GetComponent<CurrentFoot>();
        toGameOver=GameObject.FindWithTag("PlayerManager").GetComponent<ToGameOver>();  
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        //動かしている方の靴が障害物に触れたらゲームオーバー
        if (currentFoot.CurrentMovingFoot()&& collision.CompareTag("LeftFoot"))//左足
        {
            toGameOver.GameoverTrigger();
        }
        else if(!currentFoot.CurrentMovingFoot() && collision.CompareTag("RightFoot"))//右足
        {
            toGameOver.GameoverTrigger();
        }
        
    }
}
