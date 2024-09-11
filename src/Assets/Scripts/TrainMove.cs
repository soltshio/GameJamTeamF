using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainMove : MonoBehaviour
{
    [SerializeField] Transform startPos;//スタート地点
    [SerializeField] float backToStartTime=0;//スタート地点に戻るまでの時間
    [SerializeField] float speed;//速さ
    float currentTime=0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * speed*Time.deltaTime);
        currentTime += Time.deltaTime;

        if(currentTime>backToStartTime)
        {
            ResetPos();
        }
    }

    void ResetPos()
    {
        transform.position = startPos.position;
        currentTime = 0;
    }
}
