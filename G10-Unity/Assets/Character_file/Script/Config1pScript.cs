using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Config1pScript : PlayerConfig
{

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



    // Use this for initialization
    void Start()
    { 

        // プレハブを取得
        // プレハブからインスタンスを生成
        int NumOf1p = configScripts.GetPlayer1Num();

        NumOf1p = 1;
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
        Debug.Log(script.getHP());
    }

    // Update is called once per frame
    void Update()
    {
        Player1_HP = script.getHP();
        Player1_AT = script.getAT();
        Player1_DF = script.getDF();
        Player1_Pos = script.getposition();

        if (Input.GetKeyDown("w")) //前
        {
            print("w");
        }
        else if (Input.GetKeyUp("a")) //右
        {
            print("a");
        }
        else if (Input.GetKeyDown("s")) //後ろ
        {
            print("s");
        }
        else if (Input.GetKey("d")) //左
        {
            print("d");
        }
        else if (Input.GetKey("q")) //キック
        {
            print("q");
        }
        else if (Input.GetKey("e")) //パンチ
        {
            print("e");
        }

    }


}
