using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitRange : MonoBehaviour
{
    [SerializeField] Transform cameraPos;//ÉJÉÅÉâÇÃà íu
    [SerializeField] float verticalUp;
    [SerializeField] float verticalDown;
    [SerializeField] float horizontalLeft;
    [SerializeField] float horizontalRight;

    
    public void Limit()//à⁄ìÆîÕàÕÇÃêßå¿
    {
        Vector3 currentPos = transform.position;
        float cameraX = cameraPos.position.x;
        float cameraY = cameraPos.position.y;

        currentPos.x = Mathf.Clamp(currentPos.x, cameraX+horizontalLeft, cameraX+horizontalRight);//â°
        currentPos.y = Mathf.Clamp(currentPos.y, cameraY+verticalDown, cameraY + verticalUp);//èc

        transform.position = currentPos;
    }
}
