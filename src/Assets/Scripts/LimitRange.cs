using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitRange : MonoBehaviour
{
    [SerializeField] Transform cameraPos;//カメラの位置
    [SerializeField] float verticalUp;
    [SerializeField] float verticalDown;
    [SerializeField] float horizontalLeft;
    [SerializeField] float horizontalRight;

    
    public void Limit()//移動範囲の制限
    {
        Vector3 currentPos = transform.position;
        float cameraX = cameraPos.position.x;
        float cameraY = cameraPos.position.y;

        currentPos.x = Mathf.Clamp(currentPos.x, cameraX+horizontalLeft, cameraX+horizontalRight);//横
        currentPos.y = Mathf.Clamp(currentPos.y, cameraY+verticalDown, cameraY + verticalUp);//縦

        transform.position = currentPos;
    }
}
