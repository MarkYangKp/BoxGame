/*******************************************************************************
 *  Copyright(C) 2018 by DefaultCompany 
 *  All rights reserved. 
 *  文件名：RoomController.cs
 *  文件说明：
 *  具体逻辑：
 *  创建人：冷疯
 *  创建时间：2018-08-01 05:08:01
 *  最后修改时间：
 *  修改内容：
 *  存在BUG：
 *  版本：1.0
 **********************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomController : Photon.PunBehaviour {

    private static byte Version = 1;

    private PlayerCameraCtrl playerCameraCtrl;

    void Awake()
    {

        //定义房间中的所有客户端是否应与主客户机保持相同的级别，一样的加载水平，当更新或加入时，所有客户端都会加载新场景。
        PhotonNetwork.automaticallySyncScene = true;

        //如果状态是创建并可以连接
        if (PhotonNetwork.connectionStateDetailed == ClientState.PeerCreated)
        {
            //连接设置，设置客户端的版本号
            PhotonNetwork.ConnectUsingSettings(Version + "." + SceneManagerHelper.ActiveSceneBuildIndex);
        }
    }

    void Start()
    {
        playerCameraCtrl = GameObject.Find("Main Camera").GetComponent<PlayerCameraCtrl>();

        StartCoroutine(CreateOrJoinRoom());
    }

    /// <summary>
    /// 创建或者加入房间的协程
    /// </summary>
    /// <returns></returns>
    IEnumerator CreateOrJoinRoom()
    {
        //如果运行工程，直接创建或者加入房间的话，需要等待几秒先创建房间，否则会报错。
        yield return new WaitForSeconds(0.5f);

        Debug.Log("CreateOrJoinRoom");

        if (!PhotonNetwork.inRoom)
        {
            PhotonNetwork.JoinOrCreateRoom("RoomOne", new RoomOptions { MaxPlayers = 10 }, null);
        }

    }

    /// <summary>
    /// 加入房间后执行的方法，一般用来创建人物等
    /// </summary>
    public void OnJoinedRoom()
    {
        GameObject obj = PhotonNetwork.Instantiate("Player", new Vector2(100, 100), Quaternion.identity, 0) as GameObject;
        obj.transform.name = "Player";

        GameObject objx = PhotonNetwork.Instantiate("box_Game", new Vector2(0.05f, -2f), Quaternion.identity, 0) as GameObject;
        objx.transform.name = "box_Game";

        playerCameraCtrl._isPlayer = true;

        Debug.Log("join the room");

    }

    public void OnFailedToConnectToPhoton(DisconnectCause cause)
    {
        Debug.LogError("Cause: " + cause);
    }

    /// <summary>
    /// /退出程序，则退出房间
    /// </summary>
    /// <returns></returns>
    public void OnApplicationQuit()
    {
        PhotonNetwork.LeaveRoom();
    }
}
