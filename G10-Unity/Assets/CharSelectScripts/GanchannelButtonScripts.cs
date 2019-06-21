using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class GanchannelButtonScripts : MonoBehaviour, IPointerEnterHandler
{
    int GANCHAN = 2;
    configScripts config;
    int count;
    Image image1P;
    Image image2P;
    Sprite spriteGanchan;
    // Use this for initialization
    void Start()
    {
        config = GameObject.Find("Config").GetComponent<configScripts>();
        count = config.count;
        image1P = config.image1P;
        image2P = config.image2P;
        spriteGanchan = config.spriteGanchan;
    }

    public void ButtonClicked()
    {
        if (count == 0 || count == 1)
        {
            //1p決定
            GetComponent<AudioSource>().PlayOneShot(config.se);
            count += 1;
            config.count = count;
            print(string.Format("{0}Pが選択されました", count));
            if(count == 1) 
            {
                config.char1 = GANCHAN;
             }
            else if(count == 2)
            {
                config.char2 = GANCHAN;
            }

        }
    }
    // Update is called once per frame
    void Update () {
        count = config.count;
		
	}

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (count == 0)
        {
            image1P.sprite = spriteGanchan;
            print("カーソルが重なりました1");
        }
        else if (count == 1)
        {
            image2P.sprite = spriteGanchan;
            print("カーソルが重なりました2");
        }
    }

}
