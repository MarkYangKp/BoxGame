/*******************************************************************************
 *  文件名：Gear_Judgment.cs
 *  文件说明：判断汽车档位的脚本。
 *  具体逻辑：根据汽车档位进行汽车的前进后退。
 *  开发者：冷疯
 *  最后修改时间：2018年7月11日15:15
 *  修改内容：修改了汽车的加速方式，将原先的直接提速（默认速度）改为蓄力式的提速。
 *  存在BUG：切换到P档会立刻停下来，而不是逐步降速停止。
 **********************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gear_Judgment :Photon. MonoBehaviour {


    public MoveBool moveBool;

    public Rigidbody2D _rigidbody2D;


    public float Speed = 1f;

	// Use this for initialization
	void Start () {
        //moveBool = GetComponent<MoveBool>();
	}


    public void GearJudgment()
    {
        if(!photonView.isMine)
        {
            return;
        }

        if(moveBool.gear == MoveBool.Gear._Parking)
        {
            //if (Speed > 0)
            //{
            //    Speed = Speed - 10 * Time.deltaTime;
            //}
            //_rigidbody2D.AddForce(Vector3.zero * Speed * Time.deltaTime);
        }
        if (moveBool.gear == MoveBool.Gear._Drive)
        {
            if (Speed <= 2f)
            {
                Speed = Speed + 1 * Time.deltaTime;
            }
            this.transform.Translate(Vector3.up * Speed * Time.deltaTime);

        }
        if (moveBool.gear == MoveBool.Gear._Reverse)
        {
            if (Speed <= 2f)
            {
                Speed = Speed + 1 * Time.deltaTime;
            }
            this.transform.Translate(Vector3.down * Speed * Time.deltaTime);
        }
    }


	// Update is called once per frame
	void Update () {
        GearJudgment();
    }
}
