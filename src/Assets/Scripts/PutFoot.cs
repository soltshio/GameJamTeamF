using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//足を置く
//左->右の交互に置くようにする
public class PutFoot : MonoBehaviour
{
    [SerializeField] GameObject LeftFoot;
    [SerializeField] GameObject RightFoot;
    [SerializeField] GameObject FootPosition;
    [SerializeField] CurrentFoot currentFoot;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //足を置く(左、右分けて)
    public void Put()
    {
        if (currentFoot.CurrentMovingFoot())//左足を置く
        {
            LeftFoot.transform.position = FootPosition.transform.position;
        }
        else//右足を置く
        {
            RightFoot.transform.position = FootPosition.transform.position;
        }
    }
}
