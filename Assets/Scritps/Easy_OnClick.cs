using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Easy_OnClick : MonoBehaviour {

	public void StartGame_mainGame()
    {
        SceneManager.LoadScene("Loading_Game");
    }
}
