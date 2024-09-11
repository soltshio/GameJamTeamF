using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float speed;//動く速さ
    [SerializeField] float moveTime;//動かせる時間
    [SerializeField] float widthFirstPos;//初期位置決定用の幅
    [SerializeField] Transform cameraPos;//カメラの位置
    [SerializeField] Transform leftShoes;//左足の位置
    [SerializeField] Transform rightShoes;//右足の位置
    [SerializeField] CurrentFoot currentFoot;//現在の足
    private float currentMoveTime = 0;//現在の動かせる時間

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveReset()
    {
        currentMoveTime = 0;

        Vector3 currentPos = transform.position;
        float CameraY=cameraPos.position.y;

        currentPos.y = CameraY;//靴の陰のY座標位置をカメラの中心点にあわせる

        float shoesX;//靴のX座標

        if(currentFoot.CurrentMovingFoot())//左足を動かす時
        {
            shoesX = rightShoes.position.x;//右足の靴のx座標を取得
            currentPos.x = shoesX-widthFirstPos;
        }
        else//右足を動かすとき
        {
            shoesX=leftShoes.position.x;
            currentPos.x=shoesX+widthFirstPos;
        }
        
        transform.position = currentPos;
    }

    public bool MoveControl()
    {
        //動かす時間の管理
        currentMoveTime += Time.deltaTime;

        //動かす処理
        if (currentMoveTime <= moveTime)//動かせるならtrueを返す
        {
            Vector2 move = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            transform.Translate(move * speed * Time.deltaTime);
            return true;
        }
            
        //動かせなくなったらfalseを返す
        return false;
    }
}
