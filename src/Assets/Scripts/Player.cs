using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class Player : MonoBehaviour
{
    [SerializeField] Move move;
    [SerializeField] MoveTime moveTime;
    [SerializeField] PutFoot putFoot;

    void Start()
    {
        OnStart();
    }

    
    void Update()
    {
        OnUpdate();
    }
}
