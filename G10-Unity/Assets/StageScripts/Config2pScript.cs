using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Config2pScript : PlayerConfig {

    public GameObject TestChar;
    public GameObject MountainDew;    //1
    public GameObject Pepsi;          //2
    public GameObject Ganchan;        //3

    // Use this for initialization
    void Start () {
        base.HP = 1002;
        base.AT = 2002;
        base.DF = 3002;

        // プレハブを取得
        // プレハブからインスタンスを生成
        int NumOf2p = configScripts.GetPlayer2Num();
        GameObject player2;

        NumOf2p = 3;

        //2pのキャラ生成
        switch (NumOf2p)
        {
            case 1:
                player2 = Instantiate(MountainDew, new Vector3(10f, 1, 0.0f), Quaternion.identity);
                break;
            case 2:
                player2 = Instantiate(Pepsi, new Vector3(10f, 1, 0.0f), Quaternion.identity);
                break;
            case 3:
                player2 = Instantiate(Ganchan, new Vector3(10f, 1, 0.0f), Quaternion.identity);
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
		
	}
}
