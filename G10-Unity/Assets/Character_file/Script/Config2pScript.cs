using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Config2pScript : PlayerConfig
{

    public AudioClip seJab;
    public AudioClip seRisingP;
    public AudioClip seHighKick;
    public AudioClip seKick;

    public GameObject TestChar;
    public GameObject MountainDew;    //1
    public GameObject Pepsi;          //2
    public GameObject Ganchan;        //3

    public Set_Status script;

    public GameObject player2;

    public float Player2_HP;
    public float Player2_AT;
    public float Player2_DF;
    public int Player2_State = 0;
    public Vector3 Player2_Pos;
    public Vector3 Player2_Rote;

    public GameObject Enemy;
    Vector3 Enemy_Pos;

    public GameObject DamageClac;

    // Use this for initialization
    void Start()
    {

        // プレハブを取得
        // プレハブからインスタンスを生成
        int NumOf2p = configScripts.GetPlayer2Num();

        NumOf2p = 2;

        //2pのキャラ生成
        switch (NumOf2p)
        {
            case 1:
                player2 = Instantiate(MountainDew, new Vector3(10f, 0.0f, 0.0f), Quaternion.identity);
                script = player2.GetComponent<MountainDew>();
                break;
            case 2:
                player2 = Instantiate(Pepsi, new Vector3(10f, 0.0f, 0.0f), Quaternion.identity);
                script = player2.GetComponent<Pepsiman>();
                break;
            case 3:
                player2 = Instantiate(Ganchan, new Vector3(10f, 5.0f, 0.0f), Quaternion.identity);
                script = player2.GetComponent<Ganchan>();
                break;
            default://デバック用
                player2 = Instantiate(TestChar, new Vector3(10f, 0.0f, 0.0f), Quaternion.identity);
                break;
        }

        player2.name = "2pChar";
        player2.tag = "player2";

        Player2_HP = script.getHP();
        Player2_AT = script.getAT();
        Player2_DF = script.getDF();
    }

    // Update is called once per frame
    void Update()
    {
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
        //player2.transform.position = Player2_Pos;
        Player2_State = DamageClac.GetComponent<DamageCalcScript>().P2_State;
        Player2_HP = DamageClac.GetComponent<DamageCalcScript>().P2_HP;
        

        if (Input.GetKeyDown("i")) //前進
        {
            script.Player_Run();
            Player2_State = 0;
            print("i");
        }
        else if (Input.GetKeyUp("i")) //前進ストップ
        {
            script.Player_Runcancel();
            Player2_State = 0;
            print("i");
        }

        if (Input.GetKeyDown("u")) //左
        {
            script.Player_Run();
            Player2_State = 0;
            print("u");
        }

        if (Input.GetKeyUp("u")) //左ストップ
        {
            script.Player_Runcancel();
            Player2_State = 0;
            print("u");
        }

        if (Input.GetKeyDown("o")) //右
        {
            script.Player_Run();
            Player2_State = 0;
            print("o");
        }

        if (Input.GetKeyUp("o")) //右ストップ
        {
            script.Player_Runcancel();
            Player2_State = 0;
            print("o");
        }
        else if (Input.GetKeyDown("k")) //ジャブ
        {
            script.Player_Jab();
            GetComponent<AudioSource>().PlayOneShot(seJab);
            Player2_State = 1;
            print("k");
        }
        else if (Input.GetKeyDown("j")) //キック
        {
            script.Player_Spinkick();
            GetComponent<AudioSource>().PlayOneShot(seKick);
            Player2_State = 2;
            print("j");
        }
        else if (Input.GetKeyDown("l")) //ハイキック
        {
            script.Player_Hikick();
            GetComponent<AudioSource>().PlayOneShot(seHighKick);
            Player2_State = 3;
            print("l");
        }
        else if (Input.GetKeyDown("m")) //ライジングP
        {
            script.Player_RisingP();
            GetComponent<AudioSource>().PlayOneShot(seRisingP);
            Player2_State = 4;
            print("m");
        }
    }
}