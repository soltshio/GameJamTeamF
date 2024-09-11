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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("ObstacleFoot"))//‘«‚ª“ü‚Á‚½‚çŸ‚ÌƒV[ƒ“‚É
        {
            ChangeScene(scene);
        }
    }

    void ChangeScene(Scene transitionTo)
    {
        switch(transitionTo)
        {
            case Scene.level2: SceneManager.LoadScene("Lv2Scene"); break;
            case Scene.level3: SceneManager.LoadScene("Lv3Scene"); break;
            case Scene.clear: SceneManager.LoadScene("ClearScene"); break;
        }
    }
}
