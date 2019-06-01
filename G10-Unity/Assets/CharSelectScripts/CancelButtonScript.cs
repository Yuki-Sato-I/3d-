using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CancelButtonScript : MonoBehaviour {

    configScripts config;
    //Button button;
	// Use this for initialization
	void Start () {
        config = GameObject.Find("Config").GetComponent<configScripts>();
    }
	
	// Update is called once per frame
	void Update () {
        if(config.count == 0)
        {
            GetComponent<Button>().interactable = false;
        }
        else
        {
            //1pが選択されている時のみ有効
            GetComponent<Button>().interactable = true;
        }
    }

    public void CancelButtonClicked() {

        if (config.count == 1) //1pが選択されている状態だったら
        {
            config.count -= 1;
        }

    }

}
