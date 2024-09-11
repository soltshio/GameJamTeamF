using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverEffect : MonoBehaviour
{
    [SerializeField] AudioClip boice;
    [SerializeField] AudioSource boiceAudioSource;
    [SerializeField] GameObject damage;
    bool affect=false;//ゲームオーバー演出はしたか
    ToGameOver toGameOver;

    // Start is called before the first frame update
    void Start()
    {
        toGameOver = GameObject.FindWithTag("PlayerManager").GetComponent<ToGameOver>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!affect&&toGameOver.Gameover)
        {
            Affect();
        }
    }

    void Affect()
    {
        boiceAudioSource.PlayOneShot(boice);
        damage.SetActive(true);
        affect = true;
    }
}
