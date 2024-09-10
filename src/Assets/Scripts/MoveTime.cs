using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTime : MonoBehaviour
{
    [SerializeField] float moveTime;//動かせる時間
    private float currentMoveTime = 0;//現在の動かせる時間

    void Update()
    {
        currentMoveTime += Time.deltaTime;
    }

    public void ResetMoveTime()//現在の動かせる時間をリセット
    {
        currentMoveTime = 0;
    }

    public bool CanMove()//動かせるならtrueを、動かせなくなったらfalseを返す
    {
        if (currentMoveTime <= moveTime) return true;//まだ動かせる

        return false;//動かせない
    }
}
