using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeOut : MonoBehaviour
{
    [SerializeField] float fadeDuration;
    [SerializeField] float displayImageDuration;
    [SerializeField] CanvasGroup canvasGroup;

    bool StartGame = false;
    bool BackMenu = false;

    float m_Timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (StartGame || BackMenu)
        {
            Fadeout();
        }
    }

    //スタートボタン　リトライボタンを押した時
    public void PushStartButton()
    {
        if (!BackMenu)
        {
            StartGame = true;
        }
    }

    //メニューボタンを押したとき
    public void PushMenuButton()
    {
        if (!StartGame)
        {
            BackMenu = true;
        }
    }

    void Fadeout()
    {
        m_Timer += Time.deltaTime;

        canvasGroup.alpha = m_Timer / fadeDuration;

        if (m_Timer > fadeDuration + displayImageDuration)
        {
            if (StartGame) //ゲームを始める
            {
                SceneManager.LoadScene("SampleScene");
            }
            else if (BackMenu) //スタート画面に戻る
            {
                SceneManager.LoadScene("StartScene");
            }
        }
    }
}
