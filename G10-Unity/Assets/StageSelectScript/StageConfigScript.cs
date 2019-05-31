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
    //spriteStage1 = Resources.Load<Sprite>("stage1");
    //spriteStage2 = Resources.Load<Sprite>("stage2");
    //spriteStage3 = Resources.Load<Sprite>("stage3");
    //spriteStage4 = Resources.Load<Sprite>("stage4");
    
 }
	
	// Update is called once per frame
	void Update () {
		
        }
}
