using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoNextStage : MonoBehaviour
{
    enum Scene
    {
        level2,
        level3, 
        clear
    }

    [SerializeField] Scene scene;
    [SerializeField] bool fadeOut;
    [SerializeField] float fadeDuration;//何秒完全に暗転
    [SerializeField] float displayImageDuration;//完全に暗転してから何秒でシーンを遷移するか
    [SerializeField] CanvasGroup canvasGroup;
    float m_Timer;
    bool change=false;//シーンを変更するか(trueなら画面の暗転が始まってシーン遷移する)

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("ObstacleFoot"))//足が入ったら次のシーンに
        {
            change = true;
        }
    }

    void Update()
    {
        if(change)
        {
            ChangeScene();
        }
    }

    void ChangeScene()
    {
        if(fadeOut)//フェードアウトするなら
        {
            if (FadeOut()) return; //フェードアウト
        }

        switch(scene)
        {
            case Scene.level2: SceneManager.LoadScene("Lv2Scene"); break;
            case Scene.level3: SceneManager.LoadScene("Lv3Scene"); break;
            case Scene.clear: SceneManager.LoadScene("ClearScene"); break;
        }
    }

    bool FadeOut()//まだフェードアウトしきっていないならtrue、しきったならfalseを返す
    {
        m_Timer += Time.deltaTime;

        canvasGroup.alpha = m_Timer / fadeDuration;

        return (m_Timer <= fadeDuration + displayImageDuration);
    }
}
