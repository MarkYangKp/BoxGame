/*******************************************************************************
 *  文件名：MoveBool.cs
 *  文件说明：汽车档位的切换。
 *  具体逻辑：根据相应按钮的点击，实现档位的切换。
 *  开发者：冷疯
 *  最后修改时间：2018年7月11日15:10
 *  修改内容：第一次编写
 *  存在BUG：未知
 *  版本：1.0
 **********************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoveBool :Photon. MonoBehaviour {


    //枚举档位的状态
    public enum Gear
    {
        _Drive, //D档
        _Reverse, //倒挡
        _Parking, //停车
    };

    //声明枚举Gear的变量
    public Gear gear;

    public BoxTrigger pushBox;
    
    //是否捡起箱子的bool变量_isPickUp  默认值false
    public bool _isPickUp = false;

    //游戏主角Transform组件
    public Transform PlayePrefab;

    //距离差
    private Vector3 _Offvector;

    //预赋予子物体的物体
    private GameObject Box;
    //子物体
    public GameObject box;
    //赋予子物体
    private void Start()
    {
        //档位初始化为停车档位
        gear = Gear._Parking;

        
    }

    //驾驶档位
    public void Drive()
    {
        gear = Gear._Drive;
    }
	
    //倒挡
    public void Reverse()
    {
        gear = Gear._Reverse;
    }

    //停车挡
    public void Parking()
    {
        gear = Gear._Parking;
    }

    //拾起箱子
    public void PickUp()
    {
        Box = GameObject.Find("Box");
        box = GameObject.Find("box_Game");
        if (_isPickUp == false)
        {
            if (pushBox. _isTrigger == true)
            {

                box.transform.parent = Box.transform;

                _isPickUp = true;
            }
            _isPickUp = false;
        }
        else
        {
            Box.transform.DetachChildren();
            pushBox. _isTrigger = false;
            _isPickUp = false;
        }


    }

    
}
