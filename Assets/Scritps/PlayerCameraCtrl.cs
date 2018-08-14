/*******************************************************************************
 *  Copyright(C) 2015 by DefaultCompany 
 *  All rights reserved. 
 *  文件名：PlayerCameraCtrl.cs
 *  文件说明：用于摄像机跟随主角移动的脚本
 *  具体逻辑：让摄像机的Vector2等于角色的Vector2
 *  创建人：冷疯
 *  创建时间：2018-07-13 07:43:24
 *  最后修改时间：2018年7月13日19:47:35
 *  修改内容：重新编写了摄像机坐标的赋值
 *  存在BUG：未知
 *  版本：1.0
 **********************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraCtrl : MonoBehaviour {

    //主角的Transform
    public Transform playerTransform;

    public bool _isPlayer = false;

	void Update () {
        
        //获取主角的Transform组件
        //playerTransform = GameObject.Find("Player").GetComponent<Transform>();

        if(_isPlayer == true)
        {
            //让摄像机的x,y坐标等于主角的x,y坐标，而z坐标不变，仍然等于-10
            this.transform.position = new Vector3(playerTransform.position.x, playerTransform.position.y, -10);
        }
        

    }
}
