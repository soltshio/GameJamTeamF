using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitRange : MonoBehaviour
{
    [SerializeField] Transform cameraPos;//�J�����̈ʒu
    [SerializeField] float verticalUp;
    [SerializeField] float verticalDown;
    [SerializeField] float horizontalLeft;
    [SerializeField] float horizontalRight;

    
    public void Limit()//�ړ��͈͂̐���
    {
        Vector3 currentPos = transform.position;
        float cameraX = cameraPos.position.x;
        float cameraY = cameraPos.position.y;

        currentPos.x = Mathf.Clamp(currentPos.x, cameraX+horizontalLeft, cameraX+horizontalRight);//��
        currentPos.y = Mathf.Clamp(currentPos.y, cameraY+verticalDown, cameraY + verticalUp);//�c

        transform.position = currentPos;
    }
}
