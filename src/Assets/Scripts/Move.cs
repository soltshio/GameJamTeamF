using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float speed;//“®‚­‘¬‚³
    //[SerializeField] GameObject left;//¶‘«
    //[SerializeField] GameObject right;//‰E‘«
    //bool moveLeftNow = true;//¡¶‘«‚ğ“®‚©‚µ‚Ä‚¢‚é‚©AÅ‰‚É“®‚©‚·‚Ì‚Í¶‘«

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //public void SwitchMoveFoot()//“®‚©‚·‘«‚ğ“ü‚ê‘Ö‚¦‚é
    //{
    //    moveLeftNow=!moveLeftNow;//“®‚©‚·‘«‚ğ”½“]
    //}

    public void MoveControl()
    {
        Vector2 move = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        //if (moveLeftNow)//¶‘«‚ğ“®‚©‚µ‚Ä‚¢‚é
        //{
        //    left.transform.Translate(move * speed * Time.deltaTime);
        //}
        //else//‰E‘«‚ğ“®‚©‚µ‚Ä‚¢‚é
        //{
        //    right.transform.Translate(move * speed * Time.deltaTime);
        //}

        transform.Translate(move * speed * Time.deltaTime);


    }
}
