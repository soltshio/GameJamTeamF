using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("ObstacleFoot"))
        {
            //靴が障害物に触れたらゲームオーバー
            Debug.Log("ゲームオーバー");
        }
    }
}
