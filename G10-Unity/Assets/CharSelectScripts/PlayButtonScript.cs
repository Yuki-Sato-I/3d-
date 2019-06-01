using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayButtonScript : MonoBehaviour {

    configScripts config;

	// Use this for initialization
	void Start () {
        GetComponent<Button>().interactable = false;
        config = GameObject.Find("Config").GetComponent<configScripts>();
    }
	
	// Update is called once per frame
	void Update () {
        if (config.count == 2)//キャラ選択完了
        {
            GetComponent<Button>().interactable = true;
        }
        else
        {
            //1pだけもしくは両方どちらかが選択されている時のみ有効
            GetComponent<Button>().interactable = false;
        }
    }

    public void PlayButtonClicked() { 
        //ステージ選択画面に
        config.StartCoroutine("ChangeScene");
    }
}
