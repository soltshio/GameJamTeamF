using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{
    CurrentFoot currentFoot;

    void Start()
    {
        currentFoot = GameObject.FindWithTag("FootManager").GetComponent<CurrentFoot>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        //“®‚©‚µ‚Ä‚¢‚é•û‚ÌŒC‚ªáŠQ•¨‚ÉG‚ê‚½‚çƒQ[ƒ€ƒI[ƒo[
        if (currentFoot.CurrentMovingFoot()&& collision.CompareTag("LeftFoot"))//¶‘«
        {
            SceneManager.LoadScene("GameOverScene");
        }
        else if(!currentFoot.CurrentMovingFoot() && collision.CompareTag("RightFoot"))//‰E‘«
        {
            SceneManager.LoadScene("GameOverScene");
        }
        
    }
}
