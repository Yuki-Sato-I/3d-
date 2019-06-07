using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CancelButtonScript : MonoBehaviour {

    configScripts config;

	// Use this for initialization
	void Start () {
        GetComponent<Button>().interactable = false;
        config = GameObject.Find("Config").GetComponent<configScripts>();
    }
	
	// Update is called once per frame
	void Update () {
        if(config.count == 0)//初期
        {
            GetComponent<Button>().interactable = false;
        }
        else
        {
            //1pだけもしくは両方どちらかが選択されている時のみ有効
            GetComponent<Button>().interactable = true;
        }
    }

    public void CancelButtonClicked() {

        config.count -= 1;
    
    }

}
