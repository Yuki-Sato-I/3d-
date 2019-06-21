﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Stage1ButtonScript : MonoBehaviour, IPointerEnterHandler
{

    StageConfigScript stageconfig;
    Image Stageimage;
    Sprite spriteStage1;

    void Start () {
        stageconfig = GameObject.Find("GameObject").GetComponent<StageConfigScript>();
        Stageimage = stageconfig.Stageimage;
        spriteStage1 = stageconfig.spriteStage1;
    }
	
    public void OnClicked() 
    {
        print("ボタンをクリックしました");
        //シーン変更
        stageconfig.StageScene(1);
    }

	void Update () {
		
	}

    public void OnPointerEnter(PointerEventData eventData)
    {
        print("重なりました");
        Stageimage.sprite = spriteStage1;
    }
}
