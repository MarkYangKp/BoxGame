/*******************************************************************************
 *  Copyright(C) 2015 by DefaultCompany 
 *  All rights reserved. 
 *  文件名：PushBox.cs
 *  文件说明：实现在玩家控制箱子的前提下，将箱子放置到指定地点，然后销毁的功能
 *  具体逻辑：在指定地点范围的中心放置碰撞器，当箱子碰到碰撞器后进行自动销毁的方法。  
 *  开发者：冷疯
 *  创建时间：2018-07-11
 *  最后修改时间：2018年7月16日17:00:14
 *  修改内容：
 *  存在BUG：
 *  版本：1.0
 **********************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushBox : MonoBehaviour {

    public GrowBox GrowBoxs;

    

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag.Equals("P_S"))
        {
            GrowBoxs.GrowBoxs();
            Destroy(this.gameObject);

        }

    }

}
