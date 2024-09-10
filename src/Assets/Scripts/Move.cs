using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float speed;//“®‚­‘¬‚³
    [SerializeField] float moveTime;//“®‚©‚¹‚éŠÔ
    [SerializeField] Transform firstPos;//ˆÊ’uŒˆ‚ß‚Ì‘«‚Ì‰ŠúˆÊ’u
    private float currentMoveTime = 0;//Œ»İ‚Ì“®‚©‚¹‚éŠÔ

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
        transform.position = firstPos.position;
    }

    public bool MoveControl()
    {
        //“®‚©‚·ŠÔ‚ÌŠÇ—
        currentMoveTime += Time.deltaTime;

        //“®‚©‚·ˆ—
        if (currentMoveTime <= moveTime)//“®‚©‚¹‚é‚È‚çtrue‚ğ•Ô‚·
        {
            Vector2 move = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            transform.Translate(move * speed * Time.deltaTime);
            return true;
        }
            
        //“®‚©‚¹‚È‚­‚È‚Á‚½‚çfalse‚ğ•Ô‚·
        return false;
    }
}
