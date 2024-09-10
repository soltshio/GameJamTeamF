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

    bool Left = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //置く足を切り替える
    public void SwitchFoot()
    {
        if (Left)
        {
            Left = false; //右足に切り替える
        }
        else
        {
            Left = true; //左足に切り替える
        }
    }

    //足を置く(左、右分けて)
    public void Put()
    {
        if (Left)
        {
            LeftFoot.transform.position = FootPosition.transform.position;
        }
        else
        {
            RightFoot.transform.position = FootPosition.transform.position;
        }

        SwitchFoot();
    }
}
