using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class hpSlider1Script : MonoBehaviour {

	Slider hpSlider1;
	public GameObject player1;

    private int count = 0;

	// Use this for initialization
	void Start () {
		hpSlider1 = GetComponent<Slider>();

        //1フレーム後に実行する
        StartCoroutine("DelaySetup");
    }
	
	// Update is called once per frame
	void Update()
    {
        hpSlider1.value -= 10f;
        if (hpSlider1.value <= 0f && count == 1)
        {
            print("****************************************");
            print(hpSlider1.value);
            SceneManager.LoadScene("ResultScene");
            print("****************************************");
        }
    }

    private IEnumerator DelaySetup()
    {
        
        yield return null;
        float player1_HP = player1.GetComponent<Config1pScript>().Player1_HP;

        //スライダーの最大値の設定
        hpSlider1.maxValue = player1_HP;
        //スライダーの現在値の設定
        hpSlider1.value = player1_HP;
        count += 1;

        yield break;
    }
}
