using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class RandomButtonScripts : MonoBehaviour, IPointerEnterHandler
{
    configScripts config;
    int count;
    Image image1P;
    Image image2P;
    Sprite spriteRandom;
    // Use this for initialization
    void Start()
    {
        config = GameObject.Find("Config").GetComponent<configScripts>();
        count = config.count;
        image1P = config.image1P;
        image2P = config.image2P;
        spriteRandom = config.spriteRandom;
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
            image1P.sprite = spriteRandom;
            print("カーソルが重なりました1");
        }
        else if (count == 1)
        {
            image2P.sprite = spriteRandom;
            print("カーソルが重なりました2");
        }
    }

}
