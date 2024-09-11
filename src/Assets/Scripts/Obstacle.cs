using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("ObstacleFoot"))
        {
            //ŒC‚ªáŠQ•¨‚ÉG‚ê‚½‚çƒQ[ƒ€ƒI[ƒo[
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
