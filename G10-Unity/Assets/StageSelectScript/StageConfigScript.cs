using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageConfigScript : MonoBehaviour {

    public Image Stageimage;
    public Sprite spriteStage1, spriteStage2, spriteStage3, spriteStage4;

    public int char1P;
    public int char2P;

	// Use this for initialization
	void Awake ()
    {
	    Stageimage = GameObject.Find("Image").GetComponent<Image>();

        //選択したキャラ番号取得
        //1pが選択したキャラの番号
        //char1P = configScripts.GetPlayer1Num();
        //2pが選択したキャラの番号
        //char2P = configScripts.GetPlayer2Num();

        //print(char1P);
        //print(char2P);

    }

    public void StageScene(int stageNum) {
        switch (stageNum)
        {
            case 1:
                StartCoroutine("WaitTwoSeconds1");
                break;
            case 2:
                StartCoroutine("WaitTwoSeconds2");
                break;
            case 3:
                StartCoroutine("WaitTwoSeconds3");
                break;
        }
    }

    public IEnumerator WaitTwoSeconds1()
    {
        //余韻に浸る
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Stage1Scene");
    }
    public IEnumerator WaitTwoSeconds2()
    {
        //余韻に浸る
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Stage2Scene");
    }
    public IEnumerator WaitTwoSeconds3()
    {
        //余韻に浸る
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Stage3Scene");
    }
    // Update is called once per frame
    void Update () 
    {
    
    }
}
