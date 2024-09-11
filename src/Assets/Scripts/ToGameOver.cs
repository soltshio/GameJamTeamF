using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToGameOver : MonoBehaviour
{
    [SerializeField] float stopTime;//止める時間
    float currentStopTime = 0;
    bool gameover = false;

    public bool Gameover
    {
        get { return gameover; }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameover)
        {
            currentStopTime += Time.deltaTime;
        }

        if(currentStopTime>stopTime)
        {
            SceneManager.LoadScene("GameOverScene");//ゲームオーバー画面に遷移
        }
    }

    public void GameoverTrigger()
    {
        gameover = true;
    }
}
