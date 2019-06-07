using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayButtonScript : MonoBehaviour {

    configScripts config;
    public AudioClip se1;

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
        //ここ無効化ならない、なぜか
        GetComponent<Button>().interactable = false;
        //ステージ選択画面に
        GetComponent<AudioSource>().PlayOneShot(se1);
        config.StartCoroutine("ChangeScene");

    }
}
