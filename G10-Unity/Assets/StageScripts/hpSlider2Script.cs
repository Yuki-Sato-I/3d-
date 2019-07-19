using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hpSlider2Script : MonoBehaviour {

    Slider hpSlider2;
    public GameObject player2;

    // Use this for initialization
    void Start()
    {
        hpSlider2 = GetComponent<Slider>();
        //1フレーム後に実行する
        StartCoroutine("DelaySetup");

    }

    // Update is called once per frame
    void Update()
    {

        hpSlider2.value -= 10f;
    }

    private IEnumerator DelaySetup()
    {

        yield return null;
        float player2_HP = player2.GetComponent<Config2pScript>().Player2_HP;

        //スライダーの最大値の設定
        hpSlider2.maxValue = player2_HP;
        //スライダーの現在値の設定
        hpSlider2.value = player2_HP;

        yield break;
    }
}
