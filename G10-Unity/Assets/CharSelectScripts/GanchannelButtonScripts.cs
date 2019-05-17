using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class GanchannelButtonScripts : MonoBehaviour, IPointerEnterHandler
{
    configScripts config;
    int count;
    Image image1P;
    Image image2P;
    Sprite spriteGanchan;
    // Use this for initialization
    void Start()
    {
        config = GameObject.Find("GameObject").GetComponent<configScripts>();
        count = config.count;
        image1P = config.image1P;
        image2P = config.image2P;
        spriteGanchan = config.spriteGanchan;
    }

    public void ButtonClicked()
    {
        if (count == 0)
        {
            //1p決定
            count += 1;
            config.count = count;
            print(count);
        }
        else if (count == 1)
        {
            //2p決定
            count++;
            //ステージ選択画面に行く

        }
    }
    // Update is called once per frame
    void Update () {
		
	}

    public void OnPointerEnter(PointerEventData eventData)
    {
        image1P.sprite = spriteGanchan;
        print("マウスカーソルが重なりました");
    }

}
