using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitButtonScript : MonoBehaviour {
    StartButtonScript startBtn;
    // Use this for initialization
    int count;
    private void Start()
    {
        startBtn = GameObject.Find("StartButton").GetComponent<StartButtonScript>();
    }
    public void OnClickExitButton () {
        count = startBtn.count;
        if (count == 1)
        {
            GetComponent<Button>().interactable = false;
        }
        else
        {
            GetComponent<Button>().interactable = false;
            Debug.Log("実行ファイル時に有効。Unity内では無効");
            Application.Quit();
        }
    }

}
