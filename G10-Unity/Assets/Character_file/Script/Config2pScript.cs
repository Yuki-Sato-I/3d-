using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Config2pScript : PlayerConfig
{

    public GameObject TestChar;
    public GameObject MountainDew;    //1
    public GameObject Pepsi;          //2
    public GameObject Ganchan;        //3

    public Set_Status script;

    GameObject player2;

    public float Player2_HP;
    public float Player2_AT;
    public float Player2_DF;
    public Vector3 Player2_Pos;
    public Vector3 Player2_Rote;

    public GameObject Enemy;
    Vector3 Enemy_Pos;

    // Use this for initialization
    void Start()
    {

        // プレハブを取得
        // プレハブからインスタンスを生成
        int NumOf2p = configScripts.GetPlayer2Num();

        NumOf2p = 1;

        //2pのキャラ生成
        switch (NumOf2p)
        {
            case 1:
                player2 = Instantiate(MountainDew, new Vector3(10f, 1, 0.0f), Quaternion.identity);
                script = player2.GetComponent<MountainDew>();
                break;
            case 2:
                player2 = Instantiate(Pepsi, new Vector3(10f, 1, 0.0f), Quaternion.identity);
                script = player2.GetComponent<Pepsiman>();
                break;
            case 3:
                player2 = Instantiate(Ganchan, new Vector3(10f, 1, 0.0f), Quaternion.identity);
                script = player2.GetComponent<Ganchan>();
                break;
            default://デバック用
                player2 = Instantiate(TestChar, new Vector3(10f, 1, 0.0f), Quaternion.identity);
                break;
        }

        player2.name = "2pChar";
        player2.tag = "player2";
    }

    // Update is called once per frame
    void Update()
    {
        Player2_HP = script.getHP();
        Player2_AT = script.getAT();
        Player2_DF = script.getDF();
        Player2_Pos = script.getposition();
        Player2_Rote = script.getrotetion();

        Transform myTransform = this.transform;
        Vector3 worldAngle = myTransform.eulerAngles;
        Enemy_Pos = Enemy.GetComponent<Config1pScript>().Player1_Pos;


        if (Input.GetKey("u"))
        {
            worldAngle.y = (Mathf.Atan2((Enemy_Pos.x - Player2_Pos.x), (Enemy_Pos.z - Player2_Pos.z))) * Mathf.Rad2Deg - 90;
        }
        else if (Input.GetKey("o"))
        { 
            worldAngle.y = (Mathf.Atan2((Enemy_Pos.x - Player2_Pos.x), (Enemy_Pos.z - Player2_Pos.z))) * Mathf.Rad2Deg + 90;
        }
        else
        {
            worldAngle.y = (Mathf.Atan2((Enemy_Pos.x - Player2_Pos.x), (Enemy_Pos.z - Player2_Pos.z))) * Mathf.Rad2Deg;
        }

        script.setrotetion(worldAngle);
        player2.transform.eulerAngles = worldAngle;

        if (Input.GetKeyDown("i")) //前進
        {
            script.Player_Run();
            print("i");
        }
        else if (Input.GetKeyUp("i")) //前進ストップ
        {
            script.Player_Runcancel();
            print("i");
        }

        if (Input.GetKeyDown("u")) //左
        {
            script.Player_Run();
            print("u");
        }

        if (Input.GetKeyUp("u")) //左ストップ
        {
            script.Player_Runcancel();
            print("u");
        }

        if (Input.GetKeyDown("o")) //右
        {
            script.Player_Run();
            print("o");
        }

        if (Input.GetKeyUp("o")) //右ストップ
        {
            script.Player_Runcancel();
            print("o");
        }
        else if (Input.GetKeyDown("k")) //ジャブ
        {
            script.Player_Jab();
            print("k");
        }
        else if (Input.GetKey("j")) //キック
        {

            print("j");
        }
        else if (Input.GetKey("l")) //ハイキック
        {
            script.Player_Hikick();
            print("l");
        }
        else if (Input.GetKey("m")) //ライジングP
        {
            script.Player_RisingP();
            print("m");
        }
    }
}