﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Config1pScript : PlayerConfig{

    public GameObject TestChar;
    public GameObject MountainDew;    //1
    public GameObject Pepsi;          //2
    public GameObject Ganchan;        //3

    // Use this for initialization
    void Start () {
        base.HP = 100;
        base.AT = 200;
        base.DF = 300;

        // プレハブを取得
        // プレハブからインスタンスを生成
        int NumOf1p = configScripts.GetPlayer1Num();
        GameObject player1;
        //キャラ生成
        switch (NumOf1p)
        {
            case 1:
                player1 = Instantiate(MountainDew, new Vector3(-10f, 1, 0.0f), Quaternion.identity);
                break;
            case 2:
                player1 = Instantiate(Pepsi, new Vector3(-10f, 1, 0.0f), Quaternion.identity);
                break;
            case 3:
                player1 = Instantiate(Ganchan, new Vector3(-10f, 1, 0.0f), Quaternion.identity);
                break;
            default://デバック用
                player1 = Instantiate(TestChar, new Vector3(-10f, 1, 0.0f), Quaternion.identity);
                break;
        }
        player1.name = "1pChar";
        player1.tag = "player1";
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
