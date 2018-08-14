/*******************************************************************************
 *  Copyright(C) 2018 by DefaultCompany 
 *  All rights reserved. 
 *  文件名：BoxTrigger.cs
 *  文件说明：
 *  具体逻辑：
 *  创建人：冷疯
 *  创建时间：2018-08-01 07:05:29
 *  最后修改时间：
 *  修改内容：
 *  存在BUG：
 *  版本：1.0
 **********************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxTrigger : MonoBehaviour {

    //是否碰撞的bool变量_isTrigger  默认值false
    public bool _isTrigger = false;

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Box"))
        {
            _isTrigger = false;
            Debug.Log("_isTrigger: false");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Box"))
        {
            _isTrigger = true;
            Debug.Log("_isTrigger: True");
        }

    }
}
