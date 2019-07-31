﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]

public class Config1pScript : PlayerConfig
{
    private Animator anim;                      // Animatorへの参照
    private AnimatorStateInfo currentState;     // 現在のステート状態を保存する参照
    private AnimatorStateInfo previousState;    // ひとつ前のステート状態を保存する参照

    public GameObject TestChar;
    public GameObject MountainDew;    //1
    public GameObject Pepsi;          //2
    public GameObject Ganchan;        //3

    public Set_Status script;

    GameObject player1;

    public float Player1_HP;
    public float Player1_AT;
    public float Player1_DF;
    public Vector3 Player1_Pos;
    public Vector3 Player1_Rote;

    public GameObject Enemy;
    Vector3 Enemy_Pos;



    // Use this for initialization
    void Start()
    {

        // プレハブを取得
        // プレハブからインスタンスを生成
        anim = GetComponent<Animator>();
        currentState = anim.GetCurrentAnimatorStateInfo(0);
        previousState = currentState;
        Debug.Log(anim);
        int NumOf1p = configScripts.GetPlayer1Num();

        NumOf1p = 2;
        //キャラ生成
        switch (NumOf1p)
        {
            case 1:
                player1 = Instantiate(MountainDew, new Vector3(-10f, 1, 0.0f), Quaternion.identity);
                script = player1.GetComponent<MountainDew>();
                break;
            case 2:
                player1 = Instantiate(Pepsi, new Vector3(-10f, 1, 0.0f), Quaternion.identity);
                script = player1.GetComponent<Pepsiman>();
                break;
            case 3:
                player1 = Instantiate(Ganchan, new Vector3(-10f, 1, 0.0f), Quaternion.identity);
                script = player1.GetComponent<Ganchan>();
                break;
            default://デバック用
                player1 = Instantiate(TestChar, new Vector3(-10f, 1, 0.0f), Quaternion.identity);
                break;
        }
        player1.name = "1pChar";
        player1.tag = "player1";
        //HP = player1.HP;
    }

    // Update is called once per frame
    void Update()
    {
        Player1_HP = script.getHP();
        Player1_AT = script.getAT();
        Player1_DF = script.getDF();
        Player1_Pos = script.getposition();
        Player1_Rote = script.getrotetion();

        Transform myTransform = this.transform;
        Vector3 worldAngle = myTransform.eulerAngles;
        Enemy_Pos = Enemy.GetComponent<Config2pScript>().Player2_Pos;
        Debug.Log(Enemy_Pos);

        if (Input.GetKey("q"))
        {
            worldAngle.y = (Mathf.Atan2((Enemy_Pos.x - Player1_Pos.x), (Enemy_Pos.z - Player1_Pos.z))) * Mathf.Rad2Deg - 90;

        }else if (Input.GetKey("e"))
        {
            worldAngle.y = (Mathf.Atan2((Enemy_Pos.x - Player1_Pos.x), (Enemy_Pos.z - Player1_Pos.z))) * Mathf.Rad2Deg + 90;
        }
        else
        { 
            worldAngle.y = (Mathf.Atan2((Enemy_Pos.x - Player1_Pos.x), (Enemy_Pos.z - Player1_Pos.z))) * Mathf.Rad2Deg;
        }

        script.setrotetion(worldAngle);
        player1.transform.eulerAngles = worldAngle;



        if (Input.GetKeyDown("w")) //前進
        {
            script.Player_Run();
            print("w");
        }

        if (Input.GetKeyUp("w")) //前進ストップ
        { 
            script.Player_Runcancel();
            print("w");
        }

        if (Input.GetKeyDown("q")) //左
        {
            script.Player_Run();
            print("q");
        }

        if (Input.GetKeyUp("q")) //左ストップ
        {
            script.Player_Runcancel();
            print("q");
        }

        if (Input.GetKeyDown("e")) //右
        {
            script.Player_Run();
            print("e");
        }

        if (Input.GetKeyUp("e")) //右ストップ
        {
            script.Player_Runcancel();
            print("e");
        }

        else if (Input.GetKeyDown("s")) //ジャブ
        {
            script.Player_Jab();
            print("s");
        }
        else if (Input.GetKey("a")) //キック
        {

            print("a");
        }
        else if (Input.GetKey("d")) //ハイキック
        {
            script.Player_Hikick();
            print("d");
        }
        else if (Input.GetKey("x")) //ライジングP
        {
            script.Player_RisingP();
            print("x");
        }

    }


}