using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

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
        Stageimage.sprite = spriteStage1;
        print("ボタンをクリックしました");
    }

	void Update () {
		
	}

    public void OnPointerEnter(PointerEventData eventData)
    {
        print("重なりました");
        Stageimage.sprite = spriteStage1;
    }
}
