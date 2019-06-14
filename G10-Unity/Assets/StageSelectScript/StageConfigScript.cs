using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class StageConfigScript : MonoBehaviour {

    public Image Stageimage;
    public Sprite spriteStage1, spriteStage2, spriteStage3, spriteStage4;

	// Use this for initialization
	void Awake ()
    {
	    Stageimage = GameObject.Find("Image").GetComponent<Image>();

        //1pが選択したキャラの番号
        int char1P = configScripts.GetPlayer1Char();
        //2pが選択したキャラの番号
        int char2P = configScripts.GetPlayer2Char();

        print(char1P);
        print(char2P);

    }
	
	// Update is called once per frame
	void Update () 
    {
    
    }
}
