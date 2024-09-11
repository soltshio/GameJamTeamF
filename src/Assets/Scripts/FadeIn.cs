using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeIn : MonoBehaviour
{
    [SerializeField] float fadeDuration;

    bool endFadeIn = false;
    CanvasGroup canvasGroup;

    float m_Timer;

    // Start is called before the first frame update
    void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!endFadeIn)
        {
            Fadein();
        }
    }

    void Fadein()
    {
        m_Timer += Time.deltaTime;

        canvasGroup.alpha = 1 - (m_Timer / fadeDuration);

        if (m_Timer > fadeDuration)
        {
            endFadeIn = true;
        }
    }
}
