using System.Collections;
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

    public GameObject player1;

    public float Player1_HP;
    public float Player1_AT;
    public float Player1_DF;
    public int Player1_State = 0;
    public Vector3 Player1_Pos;
    public Vector3 Player1_Rote;

    public GameObject Enemy;
    Vector3 Enemy_Pos;

    public GameObject DamageClac;



    // Use this for initialization
    void Start()
    {

        // プレハブを取得
        // プレハブからインスタンスを生成
        anim = GetComponent<Animator>();
        currentState = anim.GetCurrentAnimatorStateInfo(0);
        previousState = currentState;
        int NumOf1p = configScripts.GetPlayer1Num();

        NumOf1p = 2;
        //キャラ生成
        switch (NumOf1p)
        {
            case 1:
                player1 = Instantiate(MountainDew, new Vector3(-10f, 0.0f, 0.0f), Quaternion.identity);
                script = player1.GetComponent<MountainDew>();
                break;
            case 2:
                player1 = Instantiate(Pepsi, new Vector3(-10f, 0.0f, 0.0f), Quaternion.identity);
                script = player1.GetComponent<Pepsiman>();
                break;
            case 3:
                player1 = Instantiate(Ganchan, new Vector3(-10f, 0.0f, 0.0f), Quaternion.identity);
                script = player1.GetComponent<Ganchan>();
                break;
            default://デバック用
                player1 = Instantiate(TestChar, new Vector3(-10f, 0.0f, 0.0f), Quaternion.identity);
                break;
        }
        player1.name = "1pChar";
        player1.tag = "player1";
        //HP = player1.HP;
        //print(script.getHP());
        //print("###############################");
        Player1_HP = script.getHP();
        Player1_AT = script.getAT();
        Player1_DF = script.getDF();
    }

    // Update is called once per frame
    void Update()
    {
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
        //player1.transform.position

        //情報の更新
        Player1_State = DamageClac.GetComponent<DamageCalcScript>().P1_State;
        Player1_HP = DamageClac.GetComponent<DamageCalcScript>().P1_HP;
        

        if (Input.GetKeyDown("w")) //前進
        {
            script.Player_Run();
            Player1_State = 0;
            print("w");
        }

        if (Input.GetKeyUp("w")) //前進ストップ
        { 
            script.Player_Runcancel();
            Player1_State = 0;
            print("w");
        }

        if (Input.GetKeyDown("q")) //左
        {
            script.Player_Run();
            Player1_State = 0;
            print("q");
        }

        if (Input.GetKeyUp("q")) //左ストップ
        {
            script.Player_Runcancel();
            Player1_State = 0;
            print("q");
        }

        if (Input.GetKeyDown("e")) //右
        {
            script.Player_Run();
            Player1_State = 0;
            print("e");
        }

        if (Input.GetKeyUp("e")) //右ストップ
        {
            script.Player_Runcancel();
            Player1_State = 0;
            print("e");
        }

        else if (Input.GetKeyDown("s")) //ジャブ
        {
            script.Player_Jab();
            Player1_State = 1;
            print("s");
        }
        else if (Input.GetKeyDown("a")) //キック
        {
            script.Player_Spinkick();
            Player1_State = 2;
            print("a");
        }
        else if (Input.GetKeyDown("d")) //ハイキック
        {
            script.Player_Hikick();
            Player1_State = 3;
            print("d");
        }
        else if (Input.GetKeyDown("x")) //ライジングP
        {
            script.Player_RisingP();
            Player1_State = 4;
            print("x");
        }

    }


}