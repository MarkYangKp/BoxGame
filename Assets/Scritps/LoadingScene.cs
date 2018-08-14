using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingScene : MonoBehaviour {

    public Slider processbar; //进度条

    private AsyncOperation async; //定义异步操作

    public Text Text_load;

    public string LoadSceneName;

    private int nowprocess; //当前进度条

	// Use this for initialization
	void Start () {
        StartCoroutine(loadscene()); //启动协同
	}
	
    IEnumerator loadscene()
    {
        async = SceneManager.LoadSceneAsync(LoadSceneName);

        async.allowSceneActivation = false; //默认是没有开启的

        yield return async;
    }




	// Update is called once per frame
	void Update () {
	
        if(async == null)
        {
            return;
        }

        int toprecess; //进度

        if(async.progress < 0.9f)
        {
            toprecess = (int)async.progress * 100;
        }
        else
        {
            toprecess = 100;
        }

        if(nowprocess < toprecess)
        {
            nowprocess++;
        }
        Text_load.text = (processbar.value * 100).ToString();
        processbar.value = nowprocess / 100f;
        
        if (nowprocess == 100)
        {
            async.allowSceneActivation = true;
        }

        

	}
}
