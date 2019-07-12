using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Config2pScript : PlayerConfig {

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

    // Use this for initialization
    void Start () {
        
        // プレハブを取得
        // プレハブからインスタンスを生成
        int NumOf2p = configScripts.GetPlayer2Num();

        NumOf2p = 2;

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
	void Update () {
        Player2_HP = script.getHP();
        Player2_AT = script.getAT();
        Player2_DF = script.getDF();
        Player2_Pos = script.getposition();
    }
}
