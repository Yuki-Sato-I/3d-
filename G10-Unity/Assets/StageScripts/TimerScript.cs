using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TimerScript : MonoBehaviour {

    float limitTime = 60; 
	// Use this for initialization
	void Start () { 
    }
	
	// Update is called once per frame
	void Update () {
        limitTime -= Time.deltaTime;
        GetComponent<Text>().text = limitTime.ToString("F0");

        if(GetComponent<Text>().text == "0") {
            //仮の遷移
            SceneManager.LoadScene("StartPageScene");
        }
    }
}
