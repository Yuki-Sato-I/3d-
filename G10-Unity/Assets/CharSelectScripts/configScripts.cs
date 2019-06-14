using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class configScripts : MonoBehaviour {

    public static int charSelect1;
    public static int charSelect2;

    public int char1;
    public int char2;

    public int count;
    public Image image1P;
    public Image image2P;
    public Sprite spriteFemale, spriteMale, spriteGanchan, spriteRandom;
    //SE用
    public AudioClip se;

    //何よりも早く実行
    void Awake () {
        count = 0;
        image1P = GameObject.Find("1P").GetComponent<Image>();
        image2P = GameObject.Find("2P").GetComponent<Image>();
        spriteFemale = Resources.Load<Sprite>("female");
        spriteMale = Resources.Load<Sprite>("male");
        spriteGanchan = Resources.Load<Sprite>("ganchan");
        spriteRandom = Resources.Load<Sprite>("random");

    }

    public void LoadStageSelectScene() {
        charSelect1 = char1;
        charSelect2 = char2;
        print(string.Format("{0}のキャラ", charSelect1));
        print(string.Format("{0}のキャラ", charSelect2));

        SceneManager.LoadScene("StageSelectScene");
    }

    // Update is called once per frame
    void Update () {
	}

    public IEnumerator ChangeScene()
    {

        //2P選択時に余韻に浸る
        yield return new WaitForSeconds(2);
        LoadStageSelectScene();

    }

    //キャラ情報（何を選んだか取得する関数）
    public static int GetPlayer1Char() 
    {
        return charSelect1;
     }
    public static int GetPlayer2Char()
    {
        return charSelect2;
    }

}
