/*******************************************************************************
 *  Copyright(C) 2018 by DefaultCompany 
 *  All rights reserved. 
 *  文件名：AI_Ctrl.cs
 *  文件说明：
 *  具体逻辑：
 *  创建人：冷疯
 *  创建时间：2018-08-01 12:54:36
 *  最后修改时间：
 *  修改内容：
 *  存在BUG：
 *  版本：1.0
 **********************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Ctrl : MonoBehaviour {

    //箱子的游戏物体
    private GameObject BoxPrefabAiFind;

    

    private void Update()
    {
        BoxPrefabAiFind = GameObject.Find("box_Game");
    }

    //AI移动函数
    public void AIMove()
    {
        //this.transform.Translate(Vector3);
    }




	
}
