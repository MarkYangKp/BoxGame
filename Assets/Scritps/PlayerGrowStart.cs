/*******************************************************************************
 *  Copyright(C) 2015 by DefaultCompany 
 *  All rights reserved. 
 *  文件名：PlayerGrowStart.cs
 *  文件说明：设置角色的出生点
 *  具体逻辑：给角色随机生成已有的出生点坐标
 *  创建人：冷疯
 *  创建时间：2018-07-14 09:15:01
 *  最后修改时间：2018年7月14日22:18:10
 *  修改内容：修改数组索引
 *  存在BUG：未知
 *  版本：1.0
 **********************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrowStart : MonoBehaviour {

    private GameObject[] StartPlaces = new GameObject[9];

    void Start () {

        for (int i = 0; i < 9; i++)
        {
            string placeName = i.ToString() + "_P";
            StartPlaces[i] = GameObject.Find(i.ToString() + "_P");
        }

        int l = Random.Range(0, 8);

        this.transform.position = StartPlaces[l].transform.position;

	}
	
	
	void Update () {
		
	}
}
