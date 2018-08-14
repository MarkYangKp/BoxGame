/*******************************************************************************
 *  Copyright(C) 2015 by DefaultCompany 
 *  All rights reserved. 
 *  文件名：GorwBox.cs
 *  文件说明：生成箱子的脚本文件  
 *  具体逻辑：
 *  创建人：冷疯
 *  创建时间：2018-07-16 05:53:28
 *  最后修改时间：
 *  修改内容：
 *  存在BUG：
 *  版本：1.0
 **********************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowBox : MonoBehaviour {

    public MoveBool _moveBool;
    public GameObject BoxPrefab;
	
	void Start () {
       
    }

    public void GrowBoxs()
    {
        float x, y;

        x = Random.Range(-8.6f, 8.6f);
        y = Random.Range(-6.25f, 6.25f);

        GameObject obj = PhotonNetwork.Instantiate("box_Game", new Vector2(x, y), Quaternion.identity, 0) as GameObject;
        obj.transform.name = "box_Game";

        // _moveBool.box = GameObject.Find("box_Game");
    }

    void Update () {
		
	}
}
