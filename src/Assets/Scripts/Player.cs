using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class Player : MonoBehaviour
{
    [SerializeField] Move move;
    [SerializeField] PutFoot putFoot;
    [SerializeField] CurrentFoot currentFoot;
    [SerializeField] CameraScroll cameraScroll;
    [SerializeField] LimitRange limitRange;

    void Start()
    {
        OnStart();
    }

    
    void Update()
    {
        OnUpdate();
    }
}
