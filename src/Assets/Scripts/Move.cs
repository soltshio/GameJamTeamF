using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float speed;//“®‚­‘¬‚³

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 move=new Vector2 (Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        transform.Translate (move*speed*Time.deltaTime);
    }
}
