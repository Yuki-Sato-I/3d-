using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class configScripts : MonoBehaviour {

    public int count;
    public Image image1P;
    public Image image2P;
    public Sprite spriteFemale, spriteMale, spriteGanchan, spriteRandom;

    // Use this for initialization
    void Start () {
        count = 0;
        image1P = GameObject.Find("1P").GetComponent<Image>();
        image2P = GameObject.Find("2P").GetComponent<Image>();
        spriteFemale = Resources.Load<Sprite>("female");
        spriteMale = Resources.Load<Sprite>("male");
        spriteGanchan = Resources.Load<Sprite>("ganchan");
        spriteRandom = Resources.Load<Sprite>("random");

    }
	
	// Update is called once per frame
	void Update () {
	}
}
