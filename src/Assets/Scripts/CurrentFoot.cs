using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentFoot : MonoBehaviour
{
    bool moveLeftNow = true;//¡¶‘«‚ğ“®‚©‚µ‚Ä‚¢‚é‚©
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchFoot()//“®‚©‚·‘«‚ğ”½“]
    {
        moveLeftNow=!moveLeftNow;
    }

    public bool CurrentMovingFoot()//¡“®‚©‚µ‚Ä‚¢‚é‘«‚ğ•Ô‚·(¶‘«‚È‚çtrue)
    {
        return moveLeftNow;
    }
}
